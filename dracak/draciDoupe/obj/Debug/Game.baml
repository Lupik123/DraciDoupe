   M S B A M L   `   `   `  ����E  AdraciDoupe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:draciDoupe
draciDoupe  5          draciDoupe.Game   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:draciDoupe     5        N� Title$  
DraciDoupe��5	       N� 
FontFamily$* $pack://application:,,,/fonts/#Griffy)�5
       N� FontSize$ 36(�5       N� 
Background 5      �� 5   
    �� ImageSource$ Images/cave2.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��0.33* �6   6/    � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      6   .+�5   
   �� -   5         ��Name$ profile��5       � Cursor$
 Hand��6"   $��Profile��60   $��Center=�6B   $	��Top=�6`   $	��176��6x   $��58��6�   $��1��6�   $��0,25,0,0q�6�   6�   �� 5   
   -   5        $ 	inventory��5      $
 Hand��6$   $��	Inventory��62   $��Center=�6F   $	��Top=�6c   $	��176��6{   $��58��6�   $��
0,108,0,25q�6�   $��1��6�   6�   �� 5   
   -   5        	 ��Name$	 	textBlock��5      
 �� TextAlignment$
 Justify=�6'   $
��Wrap=�6?   $��	TextBlock��6S   
�������$��2��6w   $	��428��6�   $��28(�6�   $	��Top=�6�   $��
114,50,0,0q�6�   $	��605��6�   $
��Left=�6�   �� 5   
   -   5        $ takeNote��5      $��	Take note��6#   $
��Left=�67   $	��176��6i   $��58��6u   $��
185,0,0,25q�6�   $��1��6�   $��Bottom=�6�   $y�Visible=�6�   �� 5   
   -   5        $ continue��5      $
 Hand��6#   $��Continue��61   $��Right=�6D   $	��176��6w   $��58��6�   $��
0,0,100,25q�6�   $��1��6�   $��Bottom=�6�   �� 5!   
   -   5        $ merchant��5!      $
 Hand��6#   $��1��61   $��Right=�6X   $	��381��6t   $��1��6�   $��Bottom=�6�   $	��180��6�   ��6�   Z� ��6�   Z� .��5"      �� $��Images/merchant.png��6   5#      5$      5%      