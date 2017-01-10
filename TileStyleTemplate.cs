﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace PurpleTreeSoftware.Panel
{
    public class TileStyleTemplate : DependencyObject
    {
        

        /// <summary>
        /// Constructor
        /// </summary>
        public TileStyleTemplate () {            

        }
        
        /// <summary>
        /// Background colour of tile
        /// </summary>
        public Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background. 
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(TileStyleTemplate), new PropertyMetadata(null));




        /// <summary>
        /// Colour of tile in the hover state
        /// </summary>
        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundHover.         
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(TileStyleTemplate), new PropertyMetadata(null));



        /// <summary>
        /// Colour of tile in the pressed state
        /// </summary>

        public Brush BackgroundPressed
        {
            get { return (Brush)GetValue(BackgroundPressedProperty); }
            set { SetValue(BackgroundPressedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundPressed. 
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), typeof(TileStyleTemplate), new PropertyMetadata(null));




        /// <summary>
        /// Minimum width of the tile
        /// </summary>
        public double MinWidth
        {
            get { return (double)GetValue(MinWidthProperty); }
            set { SetValue(MinWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinWidth.  
        public static readonly DependencyProperty MinWidthProperty =
            DependencyProperty.Register("MinWidth", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata((double)100));



        /// <summary>
        /// Minimum height of the tile
        /// </summary>
        public double MinHeight
        {
            get { return (double)GetValue(MinHeightProperty); }
            set { SetValue(MinHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinHeight. 
        public static readonly DependencyProperty MinHeightProperty =
            DependencyProperty.Register("MinHeight", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata((double)100));



        /// <summary>
        /// Maximum height of the tile
        /// </summary>
        public double MaxWidth
        {
            get { return (double)GetValue(MaxWidthProperty); }
            set { SetValue(MaxWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxWidth.  
        public static readonly DependencyProperty MaxWidthProperty =
            DependencyProperty.Register("MaxWidth", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata(double.PositiveInfinity));




        /// <summary>
        /// Maximum height of the tile
        /// </summary>
        public double MaxHeight
        {
            get { return (double)GetValue(MaxHeightProperty); }
            set { SetValue(MaxHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxHeight.  
        public static readonly DependencyProperty MaxHeightProperty =
            DependencyProperty.Register("MaxHeight", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata(double.PositiveInfinity));




        /// <summary>
        /// Width of the tile
        /// </summary>
        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Width.  
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata(double.NaN));



        /// <summary>
        /// Height of the tile
        /// </summary>
        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Height. 
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata(double.NaN));



        /// <summary>
        /// Margin around the tile
        /// </summary>
        public Thickness Margin
        {
            get { return (Thickness)GetValue(MarginProperty); }
            set { SetValue(MarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Margin. 
        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.Register("Margin", typeof(Thickness), typeof(TileStyleTemplate), new PropertyMetadata(new Thickness(0)));



        /// <summary>
        /// Padding within the tile
        /// </summary>

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Padding.  
        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register("Padding", typeof(Thickness), typeof(TileStyleTemplate), new PropertyMetadata(new Thickness(0)));



        /// <summary>
        /// Border thickness of the tile
        /// </summary>
        public Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderThickness.  
        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(TileStyleTemplate), new PropertyMetadata(new Thickness(0)));




        /// <summary>
        /// Border brush colour
        /// </summary>
        public Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrush.  
        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(TileStyleTemplate), new PropertyMetadata(null));




        /// <summary>
        /// Font size of the tile text
        /// </summary>
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontSize.  
        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(TileStyleTemplate), new PropertyMetadata((double)11));

        


    }
}
