   M S B A M L   `   `   `  ����P  Lw06p01-okna_dialogowe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:w06p01_okna_dialogowew06p01_okna_dialogowe  5   	   )    #w06p01_okna_dialogowe.OknoWlasne_01   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:w06p01_okna_dialogowe     5   	   -   5          � Title$  OknoWlasne_01��5   	   $	��250��6   $	��400��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ tb_okno2_01��5      $��2��6)   $
��12pt(�6=   6O   �� 5   
   -   5         �� 	IsDefault$
 True��5      $��2��6"   .��6E   OK6I   �� 5   
    �� IsCancel$
 True��6   $��1��6"   $��2��62   .��6?   Cancel6G   �� 5   
   -   5         ��Name$ textBox_okno2��5      $��1��5      $��2��6"    �� AcceptsReturn$
 True��5       �� TextWrapping$
 Wrap=�5      $
��12pt(�5      6$   5      5      