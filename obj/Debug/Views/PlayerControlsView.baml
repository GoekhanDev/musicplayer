   M S B A M L   `   `   `  ����M  IRecodedMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RecodedMusicPlayer.ViewsRecodedMusicPlayer.Views  5      E'clr-namespace:RecodedMusicPlayer.ModelsRecodedMusicPlayer.Models  5      M+clr-namespace:RecodedMusicPlayer.ViewModelsRecodedMusicPlayer.ViewModels  5      )    #RecodedMusicPlayer.Views.playerMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:RecodedMusicPlayer.Views     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6C   4models'clr-namespace:RecodedMusicPlayer.Models  5      <
viewmodels+clr-namespace:RecodedMusicPlayer.ViewModels  5      .��5   
   � .+�5      � $��Bottom=�6   $��1��6.     K� ZIndex$  0��6;    � ColumnDefinitions 5      �� 5      $	��200 �6#   $	��220��6/   �� 5      $	��220��6#   $	��350��63   �� 5      $	��400��6#    � RowDefinitions 5      �� 5      $	��190 �6    �� 5      $��80 �6    .+�5      �� $��1��6   $��3��6%   ���#0f0f1069   �� 5      -   5         ��Name$ 
albumCover��5   B   $��0��6   $  1��6"   $
��Fill=�63   ��6V   �� *AlbumCoverImage+�� 5      $��80��6   $��0��6%   $��1��65   $��Center=�6B   $��Center=�6]    �� Orientation$ 
Horizontal=�6z   $  2��6�   .+�5       �� -   5         ��Name$ songBackward��5    L   $��50��6      DisabledButton#��[  6$   ��5!      �� *BackwardCommand+.��5"      �� .+�5#      "  FontAwesome.WPF.ImageAwesome     Icon$ StepBackward=�6*      
Foreground
 �����$��10��6Q    J� Opacity$	 0.5Q�6\   5$      5%      �� 5'      -   5        $ playBTN��5'   L   $��50��6   #��[  6$   ��5(      �� *PlayCommand+.��5*      �� .+�5+        -   5        	  Name$	 playBTNIcon��5+   [   
 �����$��15��6�    6*   �� *PlayBTNIcon+
 �� FallbackValue$

 Play��6�   5,      5-      �� 5/      -   5        $ songForward��5/   L   $��50��6   #��[  6$   ��50      �� *ForwardCommand+.��51      �� .+�52        $ StepForward=�6*   
 �����$��10��6P   $	 0.5Q�6[   53      54      56      �� 58      $��1��6   $��Right=�6%   $��1��6A   
�������$	 0.1Q�6X   6h   �� 5:      $��1��6   $��1��6)   $
��Left=�66   $��25 0 0 0q�6Q   $��Center=�6c   $ 
Horizontal=�6~   $  2��6�   .+�5<      �� -   5        $ 
Horizontal=�5<      $��30��66   
������ .+�5>      �� $��40��6   #��[  6)   .��5@      �� .+�5A        -   5        $	 
volumeIcon��5A   .   $ 
VolumeDown=�6C   
 �����$��12��6h   $	 0.5Q�6s   5B      5D      �� 5F      -   5         ��Name$ volumeSlider��5F   �   $y�	Collapsed=�6    � Cursor$
 Hand��64    � Minimum$ 0Q�6B    � Maximum$	 100Q�6N    �� IsMoveToPointEnabled .   Horizontal_Slider#��[ 6�   $��Center=�6�    � Value 6\   �� *VolumeSlider+5H      5J      �� 5L      $��20q�6   .+�5M      �� -	   5         ��Name$ 	songTitle��5M   l   
���������6    �� *SongTitleText+$
 
Song Title��6l   �� 5N      -
   5        $ 
songArtist��5N   x   
�������$	 0.5Q�6j   ��6    �� *ArtistTitleText+$
 Artist��6x   5O      5Q      �� 5S      $��2��6   � 5U      $��2��6   $��1��6#   $��Center=�60   $  2��6K    5W      �� 5X      $	��800��6'   �� 5Y      $	��280��6'   $��* �66   �� 5Z      $	��100��6'   .+�5]      �� -   5        $ songCurrentDuration��5]   e   $��0��6   
�������$��Right=�6�   $��0 0 8 0q�6�   $	 0.5Q�6�   $��Center=�6�   ��6,   �� *SongCurrentDuration+$

 0:00��6�   ,   &RecodedMusicPlayer.Models.CustomSlider  5`      -   5          Name$ songDurationSlider��5`   f   $��1��6&   $
 Hand��66   $ 0Q�5a       . #��[ 6l   $��Center=�5b       5`   D   �� *DurationSlider+ 5a   %   �� *DurationSliderMaxValue+5d      �� 5f      -   5        $ songDuration��5f   k   $��2��6   
�������$
��Left=�6�   $��8 0 0 0q�6�   $	 0.5Q�6�   $��Center=�6�   ��6,   �� *SongDuration+$

 0:00�� �� Mode$ TwoWay=�6�   5h      5j      5k      5l      