   M S B A M L   `   `   `  ����E  AElit_Decor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Elit_Decor
Elit_Decor  5   	       Elit_Decor.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Elit_Decor     5   	     � Title$  
Elit_Decor��5   	   $	��325��6   $	��680��6)   .��5	      � $��Center=�6   $	��679��6%   $	��304��61   $	��Top=�6>   .+�5
      o� $��Center=�6	   $��42��6&   $	��Top=�62   $	��680��6J   
�������.@�5      m� -   5         m�Name$ Ingatlan_menu��5      $��
Ingatlanok��6%   $
��Left=�69   $	��Top=�6T   $��42��6l   $��80��6x   $
��Bold"�6�   m� 5      -   5        $ Idopontfoglalas_menu��5      $��Időpontfoglalás��6,   $��Center=�6E   $��Center=�6b   $��42��6}   $	��104��6�   $
��Bold"�6�   m� 5      -   5        $ Kereses_menu��5      $��Keresés��6$   $��Center=�65   $��Center=�6R   $��42��6m   $��55��6y   $
��Bold"�6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ Szolgaltatasok��5      $
��Left=�6%   $��
17,114,0,0q�6@   $	��652��6T      AutoGenerateColumns$ False��6   $	��117��6�   $	��Top=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Megnevezés��6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *megnev+  5      $	 Ár��6    6%   �� *ar+  5      $ Leírás��6    6)   �� *leiras+5      �� 5      $��Szolgáltatások:��6
   $
��Left=�6$   $��29��6?   $��	29,67,0,0q�6K   $	��Top=�6^   $	��103��6v   $
��Bold"�6�    J� RenderTransformOrigin$ 0.511,0.313&�6�   5      5      