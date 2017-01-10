using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PurpleTreeSoftware.Panel
{
    public sealed partial class Tile : UserControl
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="pTileText">The tile text to display</param>
        /// <param name="pEntity">The entity to return when the tile is clicked</param>
        public Tile(String pTileText, Object pEntity)
        {
            this.InitializeComponent();

            tileText.Text = pTileText == null ? String.Empty : pTileText;
            tileBorder.Tag = pEntity;

        }

       
        /// <summary>
        /// A class containing styling info for the tile
        /// </summary>
        public TileStyleTemplate StyleTemplate {get; set;}


        /// <summary>
        /// Pointer entered event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileBorder_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, TileHover.Name, false);
        }

        /// <summary>
        /// Pointer exited event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileBorder_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {           
           VisualStateManager.GoToState(this, TileNormal.Name, false);      
           
        }


        /// <summary>
        /// Pointer pressed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileBorder_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, TilePressed.Name, false);
        }

        /// <summary>
        /// Pointer released event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileBorder_PointerReleased(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, TileNormal.Name, false);
        }
        
           
        
    }
}
