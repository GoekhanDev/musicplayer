   M S B A M L   `   `   `  ����M  IRecodedMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RecodedMusicPlayer.ViewsRecodedMusicPlayer.Views  5      M+clr-namespace:RecodedMusicPlayer.ViewModelsRecodedMusicPlayer.ViewModels  6s   '    !RecodedMusicPlayer.Views.sideMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:RecodedMusicPlayer.Views     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6C   <
viewmodels+clr-namespace:RecodedMusicPlayer.ViewModels  6s   .��5	      � .+�5
   
   � $
��Left=�6   $	��200��6*   $	��200��66   ���#191a1f$��0��6Z     K� ZIndex$  1��6g    � RowDefinitions 5      �� 5      $	��150��6    �� 5      $	��190��6    .+�5      �� .��5      �� $��20q�6   .+�5      �� -   5         ��Name$ settingsBTN��5   q   $��	0 10 0 30q�6      DisabledButton#��[  60   
������ .��5      ��  �� Orientation$ 
Horizontal=�6%    J� Opacity$	 0.2Q�6>   $	��150��6L   .+�5      "  FontAwesome.WPF.ImageAwesome  $��25��6.      
Foreground
 �����   Icon$ 	EllipsisH=�6L   5      5      �� 5      -   5        $ homePageBTN��5   q   $��	0 10 0 10q�6   #��[  60   
������ ��5      �� *MainPageCommand+ 6A   �� *MainPageBTNOpacity+.��5      �� $ 
Horizontal=�6%   $	��150��6>   .+�5        $��23��6.   
 �����$ Music=�6L   �� 5      $��10 0 0 0q�6(   $��Songs��6:   
�������$��15(�6Z   5       5!      �� 5#      -   5        $ downloadPageTN��5#   q   $��	0 10 0 10q�6   #��[  60   
������ ��5$      �� *DownloaderCommand+ 6C   �� *DownloadBTNOpacity+.��5%      �� $ 
Horizontal=�6%   $	��150��6>   .+�5&        $��23��6.   
 �����$ Download=�6L   �� 5'      $��10 0 0 0q�6(   $��
Downloader��6:   
�������$��15(�6_   5(      5)      �� 5+      $��0 20 0 0q�6    
�������$��1��6?   $	 0.1Q�6J   5-      5.      �� 50      $��Right=�6   $��2��64   $  1��6E   $��1��6V   
�������$	 0.1Q�6m   6}   54      55      56      