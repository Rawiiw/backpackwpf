   M S B A M L   `   `   `  ����F  Bbackpackwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:backpackwpfbackpackwpf  5   	       backpackwpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:backpackwpf     5   	     � Title$  Backpack��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Items��5      $��0,0,10,5q�6$   $��2��66   .+�5      �� -   5         ��Name$ Adding��5      $��0��6&   $��0��66   $��20(�6C   ���	#FF2E2E2E���	#FF3D3D3D
�������$	��277��6�   $	��179��6�   .@�5      �� -   5         ��Name$ backpack��5      .��6N   Выбрать файл6\   �� 5      -   5         ��Name$ LoadFile��5      $!��Загрузить файл��6+   $��20(�6D   ���	#FF2E2E2E
����������	#FF3D3D3D$��73��6�   $	��164��6�   5      5      �� 5   
   �� 5   
   -   5        $ 	FilesList��5      $��1��6%   $��2��62   ���	#FF1F1F1F���	#FF3D3D3D
�������$��
2,142,2,-3q�6�   .@�5      �� -   5         ��Name$ BackpackTxt��5      $��1��6+   $��5��6;   $��2��6H   ���	#FF383838���	#FF3D3D3D
������� �� 
CaretBrush
 �����$��77��6�   $	��181��6�   	 �� SelectionTextBrush	 6�   Z� 6�   5      �� 5    
   -   5        $ 	Calculate��5       $��Решить��6$   $��20(�65   ���	#FF2E2E2E���	#FF3D3D3D
�������$��2��6�   $��	0,73,0,26q�6�   $��2��6�   �� 5"   
   -   5        
 ��Name$
 Matrix��5"   R   $��10,30,10,10q�6   $��1��6.   $��3��6>   $��2��6b   5#      5$      