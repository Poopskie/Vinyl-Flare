   M S B A M L   `   `   `  ����F  BVinyl Flare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Vinyl_Flare.MVVM.ViewVinyl_Flare.MVVM.View  5      G(clr-namespace:Vinyl_Flare.MVVM.ViewModelVinyl_Flare.MVVM.ViewModel  5      ?$clr-namespace:Vinyl_Flare.ConvertersVinyl_Flare.Converters  5      '    !Vinyl_Flare.MVVM.View.LibraryView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Vinyl_Flare.MVVM.View     5      >	viewmodel(clr-namespace:Vinyl_Flare.MVVM.ViewModel     5      :	Convertor$clr-namespace:Vinyl_Flare.Converters     5      
���/���  � 	Resources  5      *   $Vinyl_Flare.Converters.StringToImage   StringToImage��%   &	          5   
   6"   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��6* �6   �� 5      $��2* �6   .+�5    
   �� $��1��6   $��1��6"    �� Orientation$ Vertical=�5!      .+�5"      �� $	��100��5#      $��Comic Sans MS)�6%   $��30(�5$      $��Center=�6&   ��5"      �� *AlbumDisplay[0].AlbumName+5$   &   �� 5&      
�������$	��265��6(   $	��265��65    �� CornerRadius$ 5��5'      �� 5)      $	��250��6   $	��250��6!   $��
0 -265 0 0q�5*   <   ��5)   -   �� *AlbumDisplay[0].AlbumCoverURL+ �� 	Converter# [  5*   <   �� 5,      $��
Play Album��6   $��50��6*   $	��200��66   $
��0 25q�5-        FactoryButtonTheme#��[ 6#   ��5.      �� *PlaySongCommands[0]+50      �� 52   
   $��1��6   $��2��6"   $ Vertical=�53      .+�54      �� $	��100��55      $��Comic Sans MS)�6%   $��30(�56      $��Center=�6&   ��54      �� *AlbumDisplay[1].AlbumName+56   &   �� 58      
�������$	��265��6(   $	��265��65   $ 5��59      �� 5;      $	��250��6   $	��250��6!   $��
0 -265 0 0q�5<   <   ��5;   -   �� *AlbumDisplay[1].AlbumCoverURL+# [  5<   <   �� 5>      $��
Play Album��6   $��50��6*   $	��200��66   $
��0 25q�5?      #��[ 6#   ��5@      �� *PlaySongCommands[1]+5B      �� 5D   
   $��1��6   $��3��6"   $ Vertical=�5E      .+�5F      �� $	��100��5G      $��Comic Sans MS)�6%   $��30(�5H      $��Center=�6&   ��5F      �� *AlbumDisplay[2].AlbumName+5H   &   �� 5J      
�������$	��265��6(   $	��265��65   $ 5��5K      �� 5M      $	��250��6   $	��250��6!   $��
0 -265 0 0q�5N   <   ��5M   -   �� *AlbumDisplay[2].AlbumCoverURL+# [  5N   <   �� 5P      $��
Play Album��6   $��50��6*   $	��200��66   $
��0 25q�5Q      #��[ 6#   ��5R      �� *PlaySongCommands[2]+5T      �� 5V   
   $��1��6   $��4��6"   $ Vertical=�5W      .+�5X      �� $	��100��5Y      $��Comic Sans MS)�6%   $��30(�5Z      $��Center=�6&   ��5X      �� *AlbumDisplay[3].AlbumName+5Z   &   �� 5\      
�������$	��265��6(   $	��265��65   $ 5��5]      �� 5_      $	��250��6   $	��250��6!   $��
0 -265 0 0q�5`   <   ��5_   -   �� *AlbumDisplay[3].AlbumCoverURL+# [  5`   <   �� 5b      $��
Play Album��6   $��50��6*   $	��200��66   $
��0 25q�5c      #��[ 6#   ��5d      �� *PlaySongCommands[3]+5f      �� 5h   
   $ Vertical=�6   $��2��6,   $��4��69   .+�5m      �� $��	Next Page��6   $��Comic Sans MS)�5n      $��16(�60   #��[ 5o      $��50��5q      $	��100��6!   $	��Top=�6-   $��	100 0 0 0q�5r      ��5p      �� *NextPageICommand+5r      �� 5s      $��	Last Page��6   $��Comic Sans MS)�5t      $��16(�60   #��[ 5u      $��50��5w      $	��100��6!   $	��Top=�6-   $��
100 50 0 0q�5x      ��5v      �� *LastPageICommand+5x      5|      5�      5�      