   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   SliderButtonStyle  �� 
TargetType �� Property �� Value �� 
TargetType  SliderThumbStyle A�Name �� 
StartPoint �� EndPoint  BorderMediumColor � Color � Offset  ControlLightColor'   !System.Windows.VisualStateManager	    VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8   2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime  ControlMouseOverColor �� Value  ControlPressedColor  DisabledControlDarkColor  HorizontalSlider � RowDefinitions m�Name J� SnapsToDevicePixels m� 	Placement m� Fill  
GlyphColor �� Color ��Name �� CornerRadius 	 BorderLightColor 
 BorderDarkColor  SliderTrackDarkColor ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton �� Triggers P� Property P� Value �� 
TargetName  �� Triggers  WindowColor  ContentAreaColorLight  ContentAreaColorDark  DisabledControlLightColor  DisabledForegroundColor  SelectedBackgroundColor  SelectedUnfocusedColor  ControlMediumColor  ControlDarkColor  GlyphMouseOver  PressedBorderLightColor  PressedBorderDarkColor  DisabledBorderLightColor  DisabledBorderDarkColor  DefaultBorderBrushDarkColor  HeaderTopColor " DatagridCurrentCellBorderColor  NavButtonFrameColor  MenuPopupBrush $  ProgressBarIndicatorAnimatedFill�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %i  &	        &	 f    7  7  7  &	 �    7   7  7   '�� I    7  &	 �    &	 �    &	 �    &	 	    &	 *    &	 K    &	 l    &	 �    &	 �    &	 �    &	 �    &	 �    &	     &	 9    &	 Z    &		 �    &	 �    &	
 �    &	      &	 !    &	 B    &	 c    &	 �    &	 �    &	 �    &	 �    &	 �    &	     &	 �    �� 5      "  ��6&   .�5   
   ��  �@J�SnapsToDevicePixels$
 true��5	      �� 5
   
    �@�OverridesDefaultStyle$
 true��5      �� 5   
    � ��$ false��5      �� 5   
    � |�$ false��5      �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� 
������ 6   5      5      5      �� 5      "  n�6%   .�5   
   ��  �@J�SnapsToDevicePixels$
 true��5      �� 5   
    �@�OverridesDefaultStyle$
 true��5      �� 5   
    � ��$ 20��5      �� 5    
    � ��$ 20��5!      �� 5"   
    � �� 5#      �� 5$      " n�6"   .R�5%      A� $ Ellipse��6   $��1��5&      ��5'      �� 5(      $	 0,0&�62   $	 0,1&�5)   "   ��5+   &   � � 5,   *   # �  67   $	 0.0Q�5-   !   � 5.   *   # �  67   $	 1.0Q�5/   !   50   '   52      ��54      �� 55      $ 0.5,1&�62   $ 0.5,0&�56   "   .��57   "   � # �  6/   $ 1Q�58      � 59   "   # �  6/   5:      	 5<        5=      CommonStates��.
 5>   "     
Normal��6.     5?   "   	MouseOver��. 5@   &   �� .��5A   *   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6G   $ Ellipse��5C   1   .g�5D   .     $ 0��6B   8   5E   *   5F   +   5G   '   5H   #     5I   "   Pressed��. 5J   &   �� .��5K   *   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6G   $ Ellipse��5M   1   .g�5N   .     $ 0��6B   8  5O   *   5P   +   5Q   '   5R   #     5S   "   Disabled��. 5T   &   �� .��5U   *   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6G   $ Ellipse��5W   1   .g�5X   .     $ 0��6B   8  5Y   *   5Z   +   5[   '   5\   #   5]      5_      5`      5b      5c      �� 5f      " ��5g      .R�5h   
   �  5i      �� 5j      $
��Auto �6    �� 5k      $
��Auto �6    #��z��5l      �� 5m      $
��Auto �6    .+�5o      m� $ TopTick��6   $
 True��5p      $	 Top=�5q      $��4��5r      $y�	Collapsed=�5s       5t      �� 5u      # �  6&   5w      �� 5x      $ TrackBackground��6   $��0q�5y      $ 2��5z      $��4��5{      $��1��5|      $��0q�5}      ��5~      �� 5      $	 0,0&�6*   $	 0,1&�5�      ��5�      � � 5�   "   # � 	 6/   $	 0.0Q�5�      � 5�   "   # � 
 6/   $	 1.0Q�5�      5�      5�      ��5�      �� 5�      $	 0,0&�6*   $	 0,1&�5�      ��5�      � � 5�   "   # �  6/   $	 0.0Q�5�      � 5�   "   # �  6/   $	 1.0Q�5�      5�      5�      5�      ]� 5�      $ 
PART_Track��5�      $��1��5�       5�      �� 5�      8��  $��Slider.DecreaseLarge��5�       5�      n� 5�      8�� 6    5�      �� 5�      8�� $��Slider.IncreaseLarge��5�      5�      m� 5�      $ 
BottomTick��6   $
 True��5�      $��2��5�      # z��5�      $ Bottom=�5�      $��4��5�      $y�	Collapsed=�5�      5�       5�   
   P� 5�       �@��TickPlacement$ TopLeft=�5�      . �5�      �� $ TopTick��6    � y�$ Visible=�5�      5�      P� 5�       �@��TickPlacement$ BottomRight=�5�      . �5�      �� $ 
BottomTick��6    � y�$ Visible=�5�      5�      P� 5�       �@��TickPlacement$
 Both=�5�      . �5�      �� $ TopTick��6    � y�$ Visible=�5�      �� 5�      $ 
BottomTick��6    � y�$ Visible=�5�      5�      5�      �� 5�      "  ��6   .�5�   
   ��  �@J�SnapsToDevicePixels$
 true��5�      �� 5�   
    �@�OverridesDefaultStyle$
 true��5�        5�   
   P� 5�       �@��Orientation$ 
Horizontal=�5�      . �5�      ��  � ��$	 100��5�      �� 5�       � ��$ 50��5�      �� 5�       � ��8   5�      5�      5�      ��5�      gray��6&   ��5�      gray��60   ��5�      gray��6/   ��5�      	#FFE8EDF9��69   ��5�      	#FFC5CBF9��68   ��5�      	#FF888888��67   ��5�      Gray��62   ��5�      Gray��61   ��5�      	White��6-   ��5�      	White��6.   ��5�      	White��6,   ��5�      #FFE6FF��63   ��5�      #FFE6FF��61   ��5�      	#FF444444��6*   ��5�      /+sc#1, 0.004391443, 0.002428215, 0.242281124��6P   ��5�      	#FFCCCCCC��60   ��5�      	#FF888888��61   ��5�      	#FF444444��6/   ��5�      	#FF888888��67   ��5�      	#FF444444��66   ��5�      	#FFAAAAAA��68   ��5�      	#FF888888��67   ��5�      	Black��67   ��5      Pink��6)   ��5     	Black��6:   ��5     	White��60   ��5     	#FF3843C4��63   �� 5     $ 0.5,1&�5     $ 0.5,0&�5     .��5	  
   � # �  6   $ 0Q�5
     � 5  
   # �  6   $	 0.5Q�5     � 5  
   # �  6   $ 1Q�5     5     �� 5     $	 0,0&�5     $	 1,0&�5     ��5     � � 5     $ #FFE6FF��6   $ 0Q�5     � 5     $ #FFE6FF��6   $	 0.4Q�5     � 5     $ #FFE6FF��6   $	 0.6Q�5     � 5     $ #FFE6FF��6   $ 1Q�5     5     5      5&     