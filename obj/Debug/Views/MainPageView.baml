   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5      1&clr-namespace:System;assembly=mscorlibSystem  5      M IRecodedMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RecodedMusicPlayer.ViewsRecodedMusicPlayer.Views 5	      M+clr-namespace:RecodedMusicPlayer.ViewModelsRecodedMusicPlayer.ViewModels 6C   E'clr-namespace:RecodedMusicPlayer.ModelsRecodedMusicPlayer.Models 5      +   %RecodedMusicPlayer.Views.MainPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      :s2clr-namespace:System.Collections;assembly=mscorlib  5      .p&clr-namespace:System;assembly=mscorlib  5      2local&clr-namespace:RecodedMusicPlayer.Views  5	      <
viewmodels+clr-namespace:RecodedMusicPlayer.ViewModels  6C   4models'clr-namespace:RecodedMusicPlayer.Models  5      .��5      �   � ColumnDefinitions  5   
   �� 5      $	��200��6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��80��6   .+�5   
   � $��1��6    5      �� 5      $	��250��6    �� 5      .+�5       ��  �� Orientation$ 
Horizontal=�6   ��5"      �� 5#       �� 
StartPoint$	 0,1&�6.    �� EndPoint$
 0, 0&�6?   .��5$      �  � Offset$ 6Q�6+    � Color$ Black��66   � 5%      $ 0Q�6+   -   5        TransparentBrush��5%   6   5&      .+�5*      �� $	��180��6   $	��170��6(   $
��Left=�65   $��20q�6P   ��6\   �� *AlbumCoverImage+�� 5+      $��0 50 0 0q�6!   .+�5,      ��  K� Capitals$ AllSmallCaps=�6Y   $��CharacterEllipsis=�6|   $��30(�6�   $
��Bold"�6�   
���������6$   �� *	SongTitle+ �� FallbackValue$ 
Song Title��6�   �� 5-      
�������$��15(�6g   $��Medium"�6u   	 J� Opacity$		 0.2Q�6�   ��6$   �� *	Artists+$ Artists��6�   �� 5.      $��0 65 0 0q�6X   
�������$��12(�6}   $��Medium"�6�   ��6$   �� *	SongCount+$ 	123 Songs��6�   5/      52      �� 54      $ 
Horizontal=�6   $��15q�62   $��Right=�6>   $��Bottom=�6Z   .+�56      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 Search=�6"   $��18��60      
Foreground
 �����$��	0 3.5 0 0q�6N   $		 0.2Q�6a   $	��Top=�6o   $
��Left=�6�   �� 58      -   5         �� TextWrapping$ NoWrap=�58       �� AcceptsReturn .  $	��100��6F   $��25��59      
������ $	��Top=�6>   
������ $
��Left=�5:      $��10 0 0 0q�64   
�������$		 0.5Q�6Y   $
��Left=�5;      $��Center=�6;   $��14(�6]   ��58   R   �� *ListViewSearch+$ Search Text�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5;   �   5<      5>      � 5@      $��2��6    5B      �� 5C      $��60 �6$   �� 5D      .+�5G      ]� $��
25 20 25 0q�6   $ AllSmallCaps=�60   .+�5H      �� $��Cover��6    $��0 0 35 0q�6-   
�������$��15(�6R   �� 5I      -   5         ��Name$ TitleColumnText��5I       $��Title��69    � Cursor$
 Hand��6F   
�������$��15(�6g   6u   �� 5J      -   5        $ DurationColumnText��5J       $��Duration��6<   $
 Hand��6L   
�������$��Right=�6m   $��15(�6�   6�   5K      �� 5M      $��
20 50 20 0q�6   $	��Top=�61   $��1��6I   $��2��6Y   $		 0.1Q�6d   
�������.+�5N      ��  � LayoutTransform 5O      �� 5P       �� Angle$ 0Q�6.   5R      5S      �� 5U      -   5         ��Name$ ListMain��5U   A   $��1��6   
������    	ListStyle#��[  6~   $��Visible=�5V      ��.  ��5U   S   �� *ListViewItemSource+5X      5Z      5[      5\      5^      