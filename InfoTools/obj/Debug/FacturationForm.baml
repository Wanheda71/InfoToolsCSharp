   M S B A M L   `   `   `  ����D  @InfoTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:InfoTools	InfoTools  5          InfoTools.FacturationForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      #localclr-namespace:InfoTools  5      $	��542��5      $
��1002��6,   .��5	      �   � RowDefinitions  5
   
   �� 5      $	��13* �6   �� 5      $
��437* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DtgFacturation��5      $	��448��5      $	��500��6    $	��Top=�5      $
��Left=�6+   $��	10,15,0,0q�5         
IsReadOnly . $��2��5   P   5      �� 5   
   -   5         ��Name$ CboUtilisateur��5      $
��Left=�5      $	��Top=�6-   $��22��5      $	��120��6   $��
609,92,0,0q�5      $��1��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Id Uti��5      
������� �� DisplayMemberPath$ Prenom��5      ��5      �� *IdUti+5       �� 5"   
   -   5        $ 
CboProduit��5"      $
��Left=�5#      $	��Top=�6-   $��22��5$      $	��120��6   $��
813,92,0,0q�5%      $��1��5&      $ Id Prod��5'      
�������$ NomProd��5)      ��5*      �� *IdProd+5+      �� 5-   
   -   5         ��Name$ TxtQuantite��5-      $
��Left=�5.      $	��Top=�6-   $��22��5/      $	��120��6   $��699,163,0,0q�50       �� TextWrapping$
 Wrap=�51      $��1��52      $ Quantite��53      
�������54      �� 56   
   -   5         ��Name$ 
BtnAjouter��56      $��Ajouter��6%   $
��Left=�67   $��699,267,0,0q�6R   $��1��6g   $	��Top=�6t   $	��120��6�   $��27��6�   6�   �� 57   
   -   5        $ BtnModifier��57      $��Modifier��6&   $
��Left=�69   $��699,303,0,0q�6T   $��1��6i   $	��Top=�6v   $	��120��6�   $��27��6�   6�   �� 58   
   -   5        $ BtnSupprimer��58      $��	Supprimer��6'   $
��Left=�6;   $��699,339,0,0q�6V   $��1��6k   $	��Top=�6x   $	��120��6�   $��27��6�   6�   59      5:      