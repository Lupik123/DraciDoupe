   M S B A M L   `   `   `  ����E  AdraciDoupe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:draciDoupe
draciDoupe  5   	       draciDoupe.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:draciDoupe     5   	     � Title$  
DraciDoupe��5   	   $	��600��6   $
��1000��6)   $*��$pack://application:,,,/fonts/#Griffy)�5	   	   $��36(�5
   	   ��5      �� 5   
    �� ImageSource$ Images/cave2.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      $	��135 �6   6+   �� 5      6   .+�5   
   �� -   5         ��Name$ 	labelName��5      $*��$pack://application:,,,/fonts/#Griffy)�6'   $��Mysterious Dungeon��6Y   $��2��6s   $��Center=�6�   $��80(�6�   $
��Bold"�6�   $��Center=�6�   
������� J� OpacityMask
 �   �6�   �� 5   
   -   5        $ label1��5      $*��$pack://application:,,,/fonts/#Griffy)�6$   $��Enter nickname��6V   $��1��6l   $	��Top=�6y   $��36(�6�   $��2��6�   $��Center=�6�   
�������6�   �� 5   
   -   5         ��Name$ 
insertName��5      $��2��6&   $��50��6:   $��1��6F    �� TextWrapping$
 Wrap=�6S   $��Bottom=�6g   $	��430��6�   $��282,0q�6�   $��36(�6�   $��Center=�6�   $��2q�6�   ���#0000006�   �� 5   
   -   5         ��Name$ 
buttonName��5      $��Start��6%   $��Right=�65   $��2��6Q   $��Center=�6^   $	��200��6y   $��60��6�   $��36(�6�   $��0,0,14,0q�6�   �� 5    
   -   5        $ arena��5       $��Arena��6    $
��Left=�60   $��2��6K   $��Center=�6X   $	��200��6s   $��60��6   $��36(�6�   $��14,0,0,0q�6�   $��1��6�   �� 5!   
   -   5        $
 info��5!      $
��Info��6   $��Right=�6.   $��1��6J   $��Bottom=�6W   $	��120��6r   $��50��6~   $��36(�6�   $��0q�6�   $��1��6�   � 5#   
   -   5        	 �Name$	 	InfoPopup��5#   $   $��Center=�6   $	��600��67   $	��400��6C   $��Slide=�6P   $��2��6g   .��5$      � ��5%      �� 5&      $ Images/cave2.jpg��6!   .+�5)      �� -   5        $ 	textBlock��5)      $��0q�6/   $��28(�6:   $
��Wrap=�6H   
�������$	��320��6o   $��Center=�6|   $��Center=�6�   $	��500��6�   $��2��6�   $����Start will take you to story mode. Arena will start almost endless battle with monsters. When you fight you have 2 basic attacks. Heavy attack can be used once in 2 rounds and you can miss it.                            If you equip a bow you get a special attack with bow which is usable once in 4 rounds but you dont take any damage when used.��5*      �� 5.      -	   5        $
 exit��5.      
 � Cursor$

 Hand��6'   $��X��65   $��	0,10,10,0q�6A   $	��Top=�6T   $��30��6l   $��30��6w   $��1��6�   $��Right=�6�   $��Arial)�6�   $��24(�6�   5/      50      52      53      