   M S B A M L   `   `   `  ����K  GExerciciPractic6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ExerciciPractic6ExerciciPractic6  5   	   !    ExerciciPractic6.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ExerciciPractic6     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��Video��5      $��10q�6"   $��0��6.   $��0��6;   .+�5      r� -   5        $��
VideoFrame��5      $	��350��6-   $	��375��69    r� LoadedBehavior$ Manual=�6F    r� UnloadedBehavior$
 Stop=�6^   $��10q�6v   �� 5      -   5        $��VideoButtons��5   2    �� Orientation$ 
Horizontal=�6   $��Center=�6G   $��Bottom=�6d   .+�5      �� -   5        $��Start��5   �   $��Bottom=�6   $
��Left=�64   $��50��6O   $	��150��6[   $��0,0,10,0q�6g   $��Start��6y   6�   �� 5      -   5        $
��Stop��5   w   $��Bottom=�6   $��Right=�64   $��50��6P   $	��150��6\   $
��Stop��6h   6�   5      5      �� 5   
   -   5        $��Imatges��5      $��10q�6$   $��0��60   $��1��6=   .+�5      �� -   5        $��
ImageFrame��5      $��Images/Archer.jpg��6&   $	��350��6A   $	��375��6M   $��10q�6Z   �� 5      -   5        $��ImageButtons��5   2   $ 
Horizontal=�6   $��Center=�6G   $��Bottom=�6d   .+�5      �� -	   5        $��Previous��5   �   $��Bottom=�6   $
��Left=�64   $��50��6O   $	��150��6[   $��0,0,10,0q�6g   $��<<<- Previous��6y   6�   �� 5      -
   5        $
��Next��5   �   $��Bottom=�6   $��Right=�64   $��50��6P   $	��150��6\   $��	Next ->>>��6h   6�   5      5      5      5       