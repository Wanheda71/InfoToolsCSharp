   M S B A M L   `   `   `  ����D  @InfoTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:InfoTools	InfoTools  5          InfoTools.RendezVousForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:InfoTools     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��475��5   4   .��5	      �   � RowDefinitions  5
   
   �� 5      $	��13* �6   �� 5      $
��437* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DtgRDV��5      $	��448��5      $	��588��6    $	��Top=�5      $
��Left=�6+   $��	10,15,0,0q�5         
IsReadOnly . $��2��5   P   5      �� 5   
   -   5         ��Name$ CboUtilisateur��5      $
��Left=�5      $	��Top=�6-   $��22��5      $	��120��6   $��699,104,0,0q�5      $��1��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Id Uti��5      
������� �� DisplayMemberPath$ Prenom��5      ��5      �� *IdUti+5       (  "System.Windows.Controls.DatePicker  5"   
   $��21��6   $��4��6!   �� 5$   
   -   5         ��Name$ TxtNom��5$      $
��Left=�5%      $	��Top=�6-   $��22��5&      $	��120��6   $��699,148,0,0q�5'       �� TextWrapping$
 Wrap=�5(      $��1��5)      $	 Nom��5*      
�������5+      �� 5-   
   -   5        $ 	TxtPrenom��5-      $
��Left=�5.      $	��Top=�6-   $��22��5/      $	��120��6   $��
859,65,0,0q�50      $
 Wrap=�51      $��1��52      $ Prenom��53      
�������54      �� 56   
   -   5        $ TxtMail��56      $
��Left=�57      $	��Top=�6-   $��22��58      $	��120��6   $��859,104,0,0q�59      $
 Wrap=�5:      $��1��5;      $
 Mail��5<      
�������5=      �� 5?   
   -   5        $ TxtTel��5?      $
��Left=�5@      $	��Top=�6-   $��22��5A      $	��120��6   $��859,148,0,0q�5B      $
 Wrap=�5C      $��1��5D      $	 Tel��5E      
�������5F      �� 5H   
   -   5        $ 
TxtContenu��5H      $
��Left=�5I      $	��Top=�6-   $��22��5J      $	��120��6   $��699,195,0,0q�5K      $
 Wrap=�5L      $��1��5M      $ Contenu��5N      
�������5O        5Q   
   -   5          Name$ DpRDV��5Q      $
��Left=�5R      $	��Top=�6(   $��22��5S      $	��120��6   $��859,195,0,0q�5T      $��1��5U      
�������5V      �� 5X   
   -	   5        	 ��Name$	 
BtnAjouter��5X      $��Ajouter��6%   $
��Left=�67   $��780,283,0,0q�6R   $��1��6g   $	��Top=�6t   $	��120��6�   $��27��6�   6�   �� 5Y   
   -
   5        $	 BtnModifier��5Y      $��Modifier��6&   $
��Left=�69   $��780,319,0,0q�6T   $��1��6i   $	��Top=�6v   $	��120��6�   $��27��6�   6�   �� 5Z   
   -   5        $	 BtnSupprimer��5Z      $��	Supprimer��6'   $
��Left=�6;   $��780,355,0,0q�6V   $��1��6k   $	��Top=�6x   $	��120��6�   $��27��6�   6�   5\      5]      