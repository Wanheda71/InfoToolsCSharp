   M S B A M L   `   `   `  ����D  @InfoTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:InfoTools	InfoTools  5          InfoTools.ProduitForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:InfoTools     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��542��5      $
��1002��6,   .��5	      �   � RowDefinitions  5
   
   �� 5      $	��13* �6   �� 5      $
��437* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DtgProduit��5      $	��513��5      $	��588��6    $	��Top=�5      $
��Left=�6+   $��	10,10,0,0q�5         
IsReadOnly . $��2��5   T   5      �� 5   
   -   5         ��Name$ 	CboNumCat��5      $
��Left=�5      $	��Top=�6-   $��26��5      $	��124��6   $��
818,56,0,0q�5      $��1��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Catégorie��5      
���������5      �� �� 5    
   -   5         ��Name$ 
TxtNomProd��5       $
��Left=�5!      $	��Top=�6-   $��28��5"      $	��120��6   $��
654,56,0,0q�5#       �� TextWrapping$
 Wrap=�5$      $��1��5%      $	 Nom��5&      
�������5'      �� 5)   
   -   5        $ TxtDescProd��5)      $
��Left=�5*      $	��Top=�6-   $	��150��5+      $	��288��6   $��654,107,0,0q�5,      $
 Wrap=�5-      $��1��5.      $ Description��5/      
������� �� 	MaxLength$	 500��50   $   �� 52   
   -   5        $ TxtPrixProd��52      $
��Left=�53      $	��Top=�6-   $��26��54      $	��120��6   $��654,273,0,0q�55      $
 Wrap=�56      $��1��57      $
 Prix��58      
�������59      �� 5;   
   -   5        $ 	TxtImgSrc��5;      $
��Left=�5<      $	��Top=�6-   $��28��5=      $	��124��6   $��818,273,0,0q�5>      $
 Wrap=�5?      $��1��5@      $ Image��5A      
�������5B      �� 5D   
   -   5         ��Name$ 
BtnAjouter��5D      $��Ajouter��6%   $
��Left=�67   $��662,343,0,0q�6R   $��1��6g   $	��Top=�6t   $	��120��6�   $��27��6�   6�   �� 5E   
   -   5        $ BtnModifier��5E      $��Modifier��6&   $
��Left=�69   $��822,343,0,0q�6T   $��1��6i   $	��Top=�6v   $	��120��6�   $��27��6�   6�   �� 5F   
   -	   5        $ BtnSupprimer��5F      $��	Supprimer��6'   $
��Left=�6;   $��744,399,0,0q�6V   $��1��6k   $	��Top=�6x   $	��120��6�   $��26��6�   6�   5H      5I      