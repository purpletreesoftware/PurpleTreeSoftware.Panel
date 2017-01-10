using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;


namespace PurpleTreeSoftware.Panel
{

    public sealed partial class TilePanel : UserControl
    {
        // variables
        INotifyCollectionChanged _notifyTiles;
       
        /// <summary>
        /// The tiles to display
        /// </summary>
        public IEnumerable<Tile> Tiles
        {
            get { return (IEnumerable<Tile>)GetValue(TilesProperty); }
            set {
                // Set the value
                SetValue(TilesProperty, value);

                // Set collection changed event if value implements INotifyCollectionChanged
                if (value is INotifyCollectionChanged)
                {
                    _notifyTiles = value as INotifyCollectionChanged;
                    _notifyTiles.CollectionChanged += OnTilesCollectionChanged;
                }
            }
        }

        // Using a DependencyProperty as the backing store for Tiles.  
        public static readonly DependencyProperty TilesProperty =
            DependencyProperty.Register("Tiles", typeof(IEnumerable<Tile>), typeof(TilePanel), new PropertyMetadata(Enumerable.Empty<Tile>(), new PropertyChangedCallback(OnTilesPropertyChanged)));


        /// <summary>
        /// Event that fires if the IEnumerable tiles property changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnTilesPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var tilePanel = (TilePanel)sender;
            tilePanel.CreateRelativePanelItems();
        }

        /// <summary>
        /// Event that fires if the IEnumerable implements INotifyCollectionChanged and the tiles collection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTilesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CreateRelativePanelItems();
        }

        

        /// <summary>
        /// The depth of the grid to create
        /// </summary>
        public int Depth
        {
            get { return (int)GetValue(DepthProperty); }
            set {
                // ensure value is always greater than zero
                if (value > 0) {
                    SetValue(DepthProperty, value);
                }
                else {
                    SetValue(DepthProperty, 1);
                }

            }
        }

        // Using a DependencyProperty as the backing store for Depth.  
        public static readonly DependencyProperty DepthProperty =
            DependencyProperty.Register("Depth", typeof(int), typeof(TilePanel), new PropertyMetadata(1));


        /// <summary>
        /// Property to hold orientation enum
        /// </summary>
        public OrientationEnum Orientation
        {
            get { return (OrientationEnum)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Orientation. 
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(OrientationEnum), typeof(TilePanel), new PropertyMetadata(OrientationEnum.Vertical));



        /// <summary>
        /// Enum to represent the layout orientation
        /// </summary>
        public enum OrientationEnum { Vertical, Horizontal };
        
       

        public TileStyleTemplate StyleTemplate
        {
            get { return (TileStyleTemplate)GetValue(StyleTemplateProperty); }
            set { SetValue(StyleTemplateProperty, value); }
        }
        
        // Using a DependencyProperty as the backing store for StyleTemplate.  
        public static readonly DependencyProperty StyleTemplateProperty =
            DependencyProperty.Register("StyleTemplate", typeof(TileStyleTemplate), typeof(TileStyleTemplate), new PropertyMetadata(null));

        

        /// <summary>
        /// Action to raise when a tile click is detected
        /// </summary>
        public event Action<object> TileClicked;


        /// <summary>
        /// Constructor
        /// </summary>        
        public TilePanel()
        {           
            this.InitializeComponent();


            // Loads a default style template if one has not been set
            if (StyleTemplate == null)
            {
                StyleTemplate = (TileStyleTemplate)TilesStyleDefaultResourceDictionary["TileStyleTemplateDefaultObject"];
            }
        }


    
        /// <summary>
        /// Creates the relative panel items and relationships
        /// </summary>
        private void CreateRelativePanelItems()
        {

            // Initialise variables
            Tile[] lastTileColumnAdded = new Tile[Depth];                 
            int x = 0;
            
            // Clear all the children
            RootRelativePanel.Children.Clear();

            // Loop through the collection
            foreach (Tile currentTile in Tiles)
            {
                // set the font size of the tile equal to the user control font size
                currentTile.FontSize = this.FontSize;

                // Pass through the tile style template if one has not been set on the tile
                if (currentTile.StyleTemplate == null) { 
                    currentTile.StyleTemplate = StyleTemplate;
                }

                // Add the tile to the panel
                RootRelativePanel.Children.Add(currentTile);                

                // Create relationships based on orientation
                if (Orientation == OrientationEnum.Horizontal) { 
                    if (lastTileColumnAdded[x] != null)
                    {
                        RelativePanel.SetRightOf(currentTile, lastTileColumnAdded[x]);
                    }

                
                    if (x > 0 && lastTileColumnAdded[x - 1] != null)
                    {
                        RelativePanel.SetBelow(currentTile, lastTileColumnAdded[x-1]);
                    }
                }
                else if (Orientation == OrientationEnum.Vertical)
                {
                    if (lastTileColumnAdded[x] != null)
                    {
                        RelativePanel.SetBelow(currentTile, lastTileColumnAdded[x]);
                    }


                    if (x > 0 && lastTileColumnAdded[x - 1] != null)
                    {
                        RelativePanel.SetRightOf(currentTile, lastTileColumnAdded[x - 1]);
                    }
                }

                // Record the last tile added
                lastTileColumnAdded[x] = currentTile;

                // Increment the counter
                x++;

                // Set counter back to zero when depth exceeded
                if (x > Depth - 1)
                {
                    x = 0;
                }
        
            }
        }


        /// <summary>
        /// Event that fires when the tile is clicked. Routed event processed here. If an object is found in the tag property an action event is called. 
        /// The tag object is supplied as a parameter in the action event and returned to the subscribers of the event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootTile_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (e.OriginalSource != null) {  
                if (e.OriginalSource.GetType() == typeof(Border)) { 
                    var tile = (Border)e.OriginalSource;                 
                    if (tile.Tag != null) { 
                        TileClicked(tile.Tag);                        
                    }
                                    
                }
            }            
        }


    }
}
