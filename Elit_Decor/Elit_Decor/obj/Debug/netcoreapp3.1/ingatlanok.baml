   M S B A M L   `   `   `  ����E  AElit_Decor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Elit_Decor
Elit_Decor  5   	       Elit_Decor.ingatlanok   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Elit_Decor     5   	     � Title$  
ingatlanok��5   	   $	��507��6   $
��1239��6)   ��5	      �� 5
       �� ImageSource$" /windows-gdf8ecab41_1920.jpg��6   .��5      � $	��496��6   $	��Top=�6   $
��Left=�6-   $
��1170��6H    � ColumnDefinitions 5      �� 5      $��2* �6   �� 5      $	��63* �6   .+�5      o� $��51��6	   $	��Top=�6   ���	#FFE8E8E8$��	0,0,-68,0q�6D   $��2��6W   .@�5      m� -   5         m�Name$ Szolgaltatasok_menu��5      $��Szolgáltatások��6+   $��41��6C   $��93��6O   m� 5      -   5        $ Idopontfoglalas_menu��5      $��Időpontfoglalás��6,   $��41��6E   $��93��6Q   m� 5      -   5        $ Kereses_menu��5      $��Keresés��6$   $��41��65   $��93��6A   5      �� 5      $ ��Választható  ingatlanok:��6
   $
��Left=�6-   $��27��6H   $��	12,56,0,0q�6T   $	��Top=�6g   $	��172��6   $��2��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ adatok��5   A      AutoGenerateColumns$ False��6%   $	��286��6Q   $��10,88,-50,0q�6^   $	��Top=�6s    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   ��6   �� z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.175Q�6   T� 5      5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Leiras��64   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 700 6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *leiras+6D     5"      $
	 Hely��62   $	
 200 6@    6   �� *hely+6@     5#      $		 cm2��61   $
 80 6>    6   �� *cm2+6>     5$      $	 Szobak��6:   $
 70 6J    6   �� *szobak_szama+6J     5%      $	 Tipus��63   $
 80 6B    6   �� *tipus+6B     5&      $	 Ar��60   $	
 100 6<    6   �� *ar+6<   5(      �� 5)      $��Vásárlás:��6
   $
��Left=�6   $��28��69   $��
12,376,0,0q�6E   $	��Top=�6Y   $	��181��6q   $��2��6}   �� 5*      -   5         ��Name$	 nev��5*      $
��Left=�6   $��34��64   $��
66,404,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��198��6�   $ 0.527,0.599&�6�   $��1��6�   �� 5+      -   5         ��Name$ 
felvezetes��5+      $��Vétel��6   $
��Left=�6/   $��32��6J   $��313,444,0,0q�6V   $	��Top=�6k   $	��115��6�   $��1��6�   �� 5,      $��Teljes név:��6
   $
��Left=�6    $��34��6;   $��
10,409,0,0q�6G   $	��Top=�6[   $��68��6s   $��2��6~   �� 5-      $��Email:��6
   $
��Left=�6   $��32��66   $��
10,448,0,0q�6B   $	��Top=�6V   $��78��6n   $��2��6y   �� 5.      -   5        $ kereses��5.      $
��Left=�6   $��27��68   $��
887,10,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��183��6�   $��1��6�   �� 5/      -   5        $ gomb1��5/      $��Keresés��6   $��27��6,   $��1098,10,-51,0q�68   $	��Top=�6O   $��1��6g   �� 50      -	   5        $ email��50      $
��Left=�6   $��34��66   $��
66,443,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��198��6�   $��1��6�   52      53      