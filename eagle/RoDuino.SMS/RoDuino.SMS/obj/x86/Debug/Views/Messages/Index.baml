   M S B A M L   `   `   `  ����F  BRoDuino.SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RoDuino.SMS.ViewsRoDuino.SMS.Views  5   @   ?$clr-namespace:RoDuino.SMS.ConvertersRoDuino.SMS.Converters  6n   I)clr-namespace:RoDuino.SMS.Components.GridRoDuino.SMS.Components.Grid  6�   ?$clr-namespace:RoDuino.SMS.PropertiesRoDuino.SMS.Properties  6�   &     RoDuino.SMS.Views.Messages.Index   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   /Viewsclr-namespace:RoDuino.SMS.Views    6@   9
Converters$clr-namespace:RoDuino.SMS.Converters    6n   9local)clr-namespace:RoDuino.SMS.Components.Grid    6�   9
Properties$clr-namespace:RoDuino.SMS.Properties    6�      RoDuino.SMS.Views.View    Title$  Index��6   � 	Resources 5      *   $RoDuino.SMS.Converters.GridConverter   gridConverter  EmptyColumnTemplate  MessageColumnTemplate J� IsHitTestVisible �� 
IsReadOnly �� Path  DateColumnTemplate  DataGridViewColumnHeader �� 
TargetType �� Property �� Value ��Name  ColumnHeaderStyle	 �� TextAlignment  DataGridHeaderFontColor
 �� ElementName �� 	Converter �� ConverterParameter n�Name  
ColumnGrip  	FontColor��%�  &	        &	      &	 &     &	 �     &	 �     7   7  '�� �      5   
   6#   �� 5   
   6   �� 5	   
   .R�5
      ��  .  . $��14(�6^   ��6   �� $ Message�6^   5      �� 5   
   .R�5      �� $��14(�63   ��6   �� $
 Date�63   5      �� 5   
   " ��61   .�5      ��  � �� 5      �� 5      .R�5      �� $ Bd��6!   #���  6-   ._�5      ]� .+�5   "   �� #��z��6,   $
	 Left=�5      $��Center=�6(   $
��Bold"�6C   $��5,0,0,0q�6U   #���  5      ��5   \   �� $
 
grdClients��$ ActualWidth�8   $ 2��5      n� 5   "   $ PART_HeaderGripper��6(   8�� 6D   5      5      5      5      5       �� 5"   
   " ��6   .�5#      ��  � �� 5$      �� 5%      .R�5&      �� $��2,0,0,2q�6$   #��z��65   $
	 Left=�6k   $��Center=�6�   #���  6�   5'      5)      5*      5+      .��5,      ]� -   5         ]�Name$ 	dockPanel��5,      ��.  	 PanelGradientBrush#��� 	 68   .+�5.   
   �  
 HeaderGridMenu#��� 
 6   6:   � 50   
   -   5        $��gridContainer��50        GridContainerStyle#���  6$    � ColumnDefinitions 51      �� 52      $��* �6#   �� 53      $
��Auto �6#    � RowDefinitions 55      �� 56      $��30 �6    �� 57      $��30 �6    �� 58      $��* �6    .+�5;      �� $��0��6   $��0��6%   $��2��62     TopLeftBackgroundBrush#���  6F   |�. ._�5<      �� -   5        $��pnlLinks��5<   �    �� Orientation$ 
Horizontal=�6   $
��Left=�66   $	��Top=�6Q   $��16,0,0,0q�6i   $��30��6{   5>      5?      �� 5@      -   5         ��Name$ stackPanel1��5@   6   $��0��6   $��1��6)   $ 
Horizontal=�6K   $��Center=�6d   $��5q�6   5C      � 5E      -   5        $��grdMain��5E   0   $��0��6   $��2��6#   .+�5G      .  (RoDuino.SMS.Components.Grid.EditListView  -   5          Name$ 
grdClients��5G   %   $��-2,0,0,0q�6O   $
��Auto=�5H      $
��Auto=�6G    $� IsVirtualizing .  $� VirtualizationMode$ 	Recycling=�5I   B   ��.  �� SelectionMode$ Multiple=�5J        EditListViewStyle#���  6/     EditListViewItemStyle#���  5K      ��5G   9   Z� ��6a   Z�  �� View 5M      �� 5N       �� AllowsColumnReorder . .P�5P      ��  �� Width$ 10��6-    # FirstColumnGridViewColumnHeader �� HeaderContainerStyle# �  5Q       �� CellTemplate# [ 5R      4   .RoDuino.SMS.Components.Grid.SortListViewColumn  5U      -   5        Message��&    RoDuino.SMS.Properties.Resources   Message#��Z 5U   H      SortProperty$ Message��5V   !      	SortStyle$ DataGridViewColumnHeader��68   # �  5W   !   # [ 5X   !     5Z      -   5        Date��   Date#��Z 5Z   E   $
 Date��5[   !   $ DataGridViewColumnHeader��65   # �  5\   !   # [ 5]   !   �� 5_      $ 10��6-    " LastColumnGridViewColumnHeader# �  5`      # [ 5a      5d      5f      5h      5i      5k      5l      