   M S B A M L   `   `   `  ����  NguyenLeTieuLongWPF8    2NguyenLeTieuLongWPF.Views.CustomerManagementWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Customer Management��5   	   $	��500��6%   $	��700��62    � WindowStartupLocation$ CenterScreen=�6>   ���#F5F5F5.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� -   5        $	��Add��5      $��5q�65   ���#0078D4
�������
������ $
��10,5q�6�   �� 5      -   5        $��Update��5      $��5q�6;   ���#0078D4
�������
������ $
��10,5q�6�   �� 5      -   5        $��Delete��5      $��5q�6;   ���#0078D4
�������
������ $
��10,5q�6�   �� 5      -   5        $��Search��5      $��5q�6;   ���#0078D4
�������
������ $
��10,5q�6�   5      �� 5   
   -   5         ��Name$ PART_ListBox��5      $��1��6(   $��5q�6W   
����������#0078D4$��2q�6�   ��65   �� *	Customers+��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� $��5q�6F   ��6$   �� *CustomerFullName+6F   �� 5      $��5q�6B   ��6$   �� *EmailAddress+6B   �� 5      $��5q�6?   ��6$   �� *	Telephone+6?   5      5      5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��5q�6W   .+�5      �� -   5        $��Generate Report��5      $��5q�6L   ���#0078D4
�������
������ $
��10,5q�6�   5      5      5       