   M S B A M L   `   `   `  ����M  IRecodedMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RecodedMusicPlayer.ViewsRecodedMusicPlayer.Views  5      -    'RecodedMusicPlayer.Views.DownloaderView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:RecodedMusicPlayer.Views     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6C   .��5	      � .+�5
   
   �   � ColumnDefinitions  5      �� 5      $	��200��6#   �� 5       � RowDefinitions 5      �� 5      �� 5      $��80��6    .+�5      � $��1��6    5      �� 5      $��80 �6(   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��	20 40 0 0q�6:   $
��Left=�6M   $	��Top=�6h   .+�5      "  FontAwesome.WPF.ImageAwesome     Icon$ Search=�6'   $��18��65      
Foreground
 �����$��	0 3.5 0 0q�6S    J� Opacity$	 0.2Q�6f   $	��Top=�6t   $
��Left=�6�   �� 5      -   5         �� TextWrapping$ NoWrap=�5       �� AcceptsReturn .  $	��100��6K   $��25��5       
������ $	��Top=�6B   
������ $
��Left=�5!      $��10 0 0 0q�68   
�������$	 0.5Q�6]   $
��Left=�5"      $��Center=�6?   $��14(�6a   ��5   W   �� *ListViewSearch+ �� FallbackValue$ Search Text��	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.��5"   �   5#      5%      � 5'      $��2��6    5)      �� 5*      $��60 �6(   �� 5+      .+�5.      ]� $��
25 20 25 0q�6     K� Capitals$ AllSmallCaps=�64   .+�5/      �� $��Cover��6$   $��0 0 35 0q�61   
�������$��15(�6V   �� 50      -   5         ��Name$ TitleColumnText��50   $   $��Title��6=    � Cursor$
 Hand��6J   
�������$��15(�6k   6y   �� 51      -   5        $ DurationColumnText��51   $   $��Duration��6@   $
 Hand��6P   
�������$��Right=�6q   $��15(�6�   6�   52      �� 54      $��
20 50 20 0q�6!   $	��Top=�65   $��1��6M   $��2��6]   $	 0.1Q�6h   
�������.+�55      ��  � LayoutTransform 56      �� 57   "    �� Angle$ 0Q�62   59      5:      �� 5<      $��1��6    
�������$	 0.2Q�6�   $��Center=�6�   $��Center=�6�   ��6-   �� *
NoSongText+$* $Search shows results from SoundCloud��6�   �� 5>      -   5         ��Name$ ListMain��5>   E   $��1��6   
������ $��Visible=�5?      ��.  ��5>   W   �� *ListViewItemSource+��5@      �� 5A       �� 
TargetType" ��6$      	ListStyle �� BasedOn# [  5B   %   .�5E   "   ��  �� Property � �� �� Value 5F   &   �� 5G   *   .R�5H   .   ]� -   5        $��0 5 0 0q�5H   8   
 � Tag 6�   ��  �� ElementName$ Duration����5I   2   �� 5J   6   " ]�6<    �� Triggers 5K   :   P� 5L   >    P� Property �@J�IsMouseOver P� Value . . �5M   B   ��  � �� �#2424296_   5N   ?   P� 5O   >    �@J�IsMouseOver .  . �5P   B   ��  � ��
 ���� 6_   5Q   ?   5S   7   .+�5V   2   ��  ��Name$ 
AlbumCover��68   $��50��6e   $��20 3 3 3q�6p   $��50��6�   $
��Left=�6�   ��6L   �� *cover+6�   �� 5X   2   $��20 3 3 3q�6=   .+�5Y   6   �� $ Title��6@   
�������$��14(�5Z   9   $��Medium"�5[   9   $��CharacterEllipsis=�5\   9   $	��400��5]   9   ��5Y   O   �� *title+5]   9   �� 5_   6   
�������$��14(�6r   ��6@   �� *artistsJoined+6r   5`   3   � 5b   2   $��Right=�67   $��Center=�6S   $��0 0 20 0q�6n   .+�5c   6   �� $ Duration��6@   -   5        $��Medium"�5c   �   
���������6R   �� *durationString+5e   7   5f   3   5g   /   5h   +   5j   #   5k      5m      5o      5q      5r      5s      5t      