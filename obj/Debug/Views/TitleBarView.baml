   M S B A M L   `   `   `  ����M  IRecodedMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RecodedMusicPlayer.ViewModelsRecodedMusicPlayer.ViewModels  5      +    %RecodedMusicPlayer.Views.titleBarView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      <
viewmodels+clr-namespace:RecodedMusicPlayer.ViewModels  5      $��30��5	   7   .��5      � .+�5   
   � -   5          �Name$  TitleBar��5   '   $	��Top=�6    K� ZIndex$ 3��69   
������  � ColumnDefinitions 5      �� 5      �� 5      $��90��6#   .+�5      �� -   5        
������ $ 3��5   ,   6=   �� 5      $��30��6   $��1��6%   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome . $��Center=�5      $��Right=�64    �� Orientation$ 
Horizontal=�6P   .+�5      �� -   5         ��Name$ minimize��5   N   $��30��6      TransparentStyle#��[  6$   ��6`   �� *MinimizeWindowCommand+��5      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �.��5      �� $��Center=�6!   .+�5      "  FontAwesome.WPF.ImageAwesome  $��10��6*   	   
Foreground
	 �����
   Icon$
 WindowMinimize=�6H   5      5      �� 5!      $��30��6   #��[  6$   ��6O   �� *MaximizeWindowCommand+��5"      ��  �� $ FindAncestor=�" �.��5#      �� $��Center=�6!   .+�5$        $��10��6*   
	 �����$
 WindowMaximize=�6H   5%      5&      �� 5(      $��30��6   #��[  6$   ��6N   �� *CloseWindowCommand+��5)      ��  �� $ FindAncestor=�" �.��5*      �� $��Center=�6!   .+�5+        $��10��6*   
	 �����$
 Remove=�6H   5,      5-      5/      50      51      52      