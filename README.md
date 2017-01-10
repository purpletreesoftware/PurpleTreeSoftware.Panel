# PurpleTreeSoftware.Panel

User control for generating clickable tiles in a .Net C# UWP applications


Add a reference to your project
```
using PurpleTreeSoftware.Panel;
```

Then add a namespace to your xaml page
```
xmlns:tile="using:PurpleTreeSoftware.Panel"
```

Then add the controls to your xaml page. Note to update the x:Bind path to point to your variable. 
Parameters are;
Depth: How many rows or columns to create (depending on whether the orientation is horitonal or vertical)
Orientation: Stack the tiles in a horizontal or vertical fashion
TileClicked: Event that fires when a tile is clicked
StyleTemplate: A custom class containing formatting information for the tile
```
<tile:TilePanel x:Name="TilePanel" Depth="2" Orientation="Vertical" Tiles="{x:Bind TileItems, Mode=OneWay}" TileClicked="TilePanel_TileClicked" StyleTemplate="{StaticResource TileStyleTemplateObject}">
                                    
```   


In your styles xaml file create a static resource as follows for the StyleTemplate parameter;
```
 <!-- Tile Panel Style -->
    <SolidColorBrush x:Key="TileBackgroundHoverBrush" Color="{ThemeResource SystemChromeMediumColor}"/>
    <SolidColorBrush x:Key="TileBackgroundPressedBrush" Color="{ThemeResource SystemChromeHighColor}"/>
    <SolidColorBrush x:Key="TileBackgroundNormalBrush" Color="{ThemeResource SystemChromeLowColor}"/>
    <SolidColorBrush x:Key="TileBorderBrush" Color="{ThemeResource SystemChromeHighColor}"/>
    
    <tilepanel:TileStyleTemplate x:Key="TileStyleTemplateObject" >
        <tilepanel:TileStyleTemplate.Background><StaticResource ResourceKey="TileBackgroundNormalBrush" /></tilepanel:TileStyleTemplate.Background>
        <tilepanel:TileStyleTemplate.BackgroundHover><StaticResource ResourceKey="TileBackgroundHoverBrush" /></tilepanel:TileStyleTemplate.BackgroundHover>
        <tilepanel:TileStyleTemplate.BackgroundPressed><StaticResource ResourceKey="TileBackgroundPressedBrush" /></tilepanel:TileStyleTemplate.BackgroundPressed>
        <tilepanel:TileStyleTemplate.BorderBrush><StaticResource ResourceKey="TileBorderBrush" /></tilepanel:TileStyleTemplate.BorderBrush>
        <tilepanel:TileStyleTemplate.BorderThickness>1</tilepanel:TileStyleTemplate.BorderThickness>
        <tilepanel:TileStyleTemplate.MinWidth>100</tilepanel:TileStyleTemplate.MinWidth>
        <tilepanel:TileStyleTemplate.MinHeight>100</tilepanel:TileStyleTemplate.MinHeight>
        <tilepanel:TileStyleTemplate.Width>NaN</tilepanel:TileStyleTemplate.Width>
        <tilepanel:TileStyleTemplate.Height>NaN</tilepanel:TileStyleTemplate.Height>
        <tilepanel:TileStyleTemplate.Margin>3</tilepanel:TileStyleTemplate.Margin>
        <tilepanel:TileStyleTemplate.Padding>3</tilepanel:TileStyleTemplate.Padding>
        <tilepanel:TileStyleTemplate.FontSize>20</tilepanel:TileStyleTemplate.FontSize>
    </tilepanel:TileStyleTemplate>

```
