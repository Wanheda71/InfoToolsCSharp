   M S B A M L   `   `   `  ����D  @InfoTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:InfoTools	InfoTools  5   	       InfoTools.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:InfoTools     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  InfoTools - Projet Lourd��5	   	   $	��600��6*   $
��1080��67    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z    � WindowStyle$
 None=�6   
�������
������� � Icon$ algorithm.png��6�    � 	Resources 5
         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 60Q�63     5      $ 0:0:0.5��6'   $		 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $		 200Q�63     5      $ 0:0:0.5��6'   $	 60Q�69   5      5      5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ BtnOpenMenu��67   .[�5      �� #��[  6   5      :� 5   
   $ ButtonBase.Click��6   $ BtnCloseMenu��67   .[�5      �� #��[ 6   5      .��5"      � 
������� � RowDefinitions 5#   
   �� 5$      �� 5%      $	��99* �6   .+�5(   
   � -   5         �Name$ GridUI��5(      $
��1020��6   $��Center=�6,   
�������$��	60,54,0,0q�6a   $��1��6t    5)      �� 5*      $
��181* �6    �� 5+      $	��89* �6    .+�5-         InfoTools.AccueilForm  -   5          Name$ 	UCAccueil��5-       $y�Visible=�63   $��2��6H       InfoTools.UtilisateursForm  5.      -   5          Name$ UCUtilisateur��5.   %   $y�	Collapsed=�6<   $
��0,14q�6S   $��2��6a      InfoTools.ProduitForm  5/      -   5          Name$ 	UCProduit��5/       $y�	Collapsed=�63   $��9,0,9,-2q�6J   $��2��6\      InfoTools.RendezVousForm  50      -   5          Name$ UCRendezVous��50   #   $y�	Collapsed=�69   $
��0,32q�6P   $��2��6^      InfoTools.FacturationForm  51      -   5          Name$ UCFacturation��51   $   $y�	Collapsed=�6;   $��2��6R      InfoTools.GraphiqueForm  52      -   5          Name$ UCGraphique��52   "   $y�	Collapsed=�67   $��2��6N   54      � 57   
   $��60��6   $	��Top=�6   ���	#FFD17D28$��2��6J   .+�58      �� $��
INFO-TOOLS��6   $
��Bold"�6*   $��overline{�6<   $��Center=�6W   $��Center=�6t   $��22(�6�   �� 59      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5:      �� $
��Menu��6   $��Center=�6(   $��18(�6C   '  !MaterialDesignThemes.Wpf.PopupBox  5;      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 5<      �� $	��150��6!   .+�5=      �� -	   5         ��Name$ BtnPopUpClose��5=   !   $��Quitter��68   6J   5>      5?      5@      5A      � 5F   
   -
   5        $ GridMenu��5F      $��60��6!   $
��Left=�6,   ���	#FF835D36$��2��6^   .+�5G      �� .+�5H      � $	��150��6   
�������.+�5I      �� -   5        $ BtnCloseMenu��5I      $��60��63   $��60��6>   $	��Top=�6w   $��Right=�6�   $y�	Collapsed=�6�   ��6J   Z� ��6`   Z� .��5J      '	  !MaterialDesignThemes.Wpf.PackIcon	  ���	#FF835D36 	  Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5K      �� 5L      -   5        $ BtnOpenMenu��5L      $��60��62   $��60��6=   $	��Top=�6v   $��Right=�6�   ��6I   Z� ��6_   Z� .��5M      	  ���	#FF835D36$
 Menu=�6I   $��25��6U   $��25��6`   5N      5O      �� 5P      $��Disabled=�6   ���	#FFD17D28.@�5R      �� -   5         ��Name$ BtnHome��5R   /   $��60��6#   .��5S      �� $ 
Horizontal=�6%   .+�5T      	  $
 Home=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   �� 5U      $
��Home��6(   $��Center=�64   $��20 10q�6O   5V      5W      �� 5Y      -   5        $ BtnUtilisateur��5Y   #   $��60��6;   .��5Z      �� $ 
Horizontal=�6%   .+�5[      	  $ Users=�66   $��25��6C   $��25��6N   $��10q�6Z   $��Center=�6f   �� 5\      $��Utilisateurs��6(   $��Center=�6<   $��20 10q�6W   5]      5^      �� 5`      -   5        $ BtnRendezVous��5`   #   $��60��6:   .��5a      �� $ 
Horizontal=�6%   .+�5b      	  $ ClipboardClock=�66   $��25��6L   $��25��6W   $��10q�6c   $��Center=�6o   �� 5c      $��Rendez-Vous��6(   $��Center=�6;   $��20 10q�6V   5d      5e      �� 5g      -   5        $ BtnFacturation��5g   #   $��60��6;   .��5h      �� $ 
Horizontal=�6%   .+�5i      	  $ 
AlarmPanel=�66   $��25��6H   $��25��6S   $��10q�6_   $��Center=�6k   �� 5j      $��Facturation��6(   $��Center=�6;   $��20 10q�6V   5k      5l      �� 5n      -   5        $ 
BtnProduit��5n   #   $��60��67   .��5o      �� $ 
Horizontal=�6%   .+�5p      	  $
 Cart=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   �� 5q      $��Produits��6(   $��Center=�68   $��20 10q�6S   5r      5s      �� 5u      -   5        $ BtnGraphique��5u   #   $��60��69   .��5v      �� $ 
Horizontal=�6%   .+�5w      	  $ ChartBar=�66   $��25��6F   $��25��6Q   $��10q�6]   $��Center=�6i   �� 5x      $��Statistiques��6(   $��Center=�6<   $��20 10q�6W   5y      5z      5|      5}      5~      5�      5�      