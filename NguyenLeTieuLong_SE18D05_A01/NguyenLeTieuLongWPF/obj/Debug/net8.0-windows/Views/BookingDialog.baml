   M S B A M L   `   `   `  ����  NguyenLeTieuLongWPF-    'NguyenLeTieuLongWPF.Views.BookingDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Booking Dialog��5   	   $	��400��6    $	��300��6-    � WindowStartupLocation$ CenterOwner=�69   ���#F5F5F5.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��10��6    $��Booking Details��62   $��0,0,0,20q�6K   
����������#0078D4$��2q�6�   .��5      �� $��10q�6   .+�5      �� $��0��6   $��Booking ID:��6%   $
��Bold"�6;   ���#0078D46M   �� 5      $��1��6    �� 
IsReadOnly$
 True��6'   $��0,5,0,10q�6y   ���#E6F0FA���#0078D4$��1q�6�   ��69   �� *	BookingID+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��2��6   $��Customer ID:��6%   $
��Bold"�6<   ���#0078D46N   �� 5      -   5         ��Name$ CustomerComboBox��5   (   $��3��6    �� DisplayMemberPath$ CustomerFullName��6B    �� SelectedValuePath$ 
CustomerID��6g   $��0,5,0,10q�6�   
����������#0078D4$��1q�6�   �� 5      $��4��6   $��Room ID:��6%   $
��Bold"�68   ���#0078D46J   �� 5      -   5        $ RoomComboBox��5   (   $��5��6   $ 
RoomNumber��6>   $ RoomID��6]   $��0,5,0,10q�6�   
����������#0078D4$��1q�6�   �� 5      $��6��6   $��Start Date:��6%   $
��Bold"�6;   ���#0078D46M   (  "System.Windows.Controls.DatePicker  5      $��7��6   $��0,5,0,10q�6r   
����������#0078D4$��1q�6�      SelectedDate 6*   �� *	StartDate+$ PropertyChanged=�6�   �� 5      $��8��6   $��	End Date:��6%   $
��Bold"�69   ���#0078D46K     5      $��9��6   $��0,5,0,10q�6p   
����������#0078D4$��1q�6�    6*   �� *	EndDate+$ PropertyChanged=�6�   5       5!      �� 5#   
   $��10��6   	 �� Orientation$	 
Horizontal=�6#   $��Right=�6<   $��5q�6X   .+�5$      �� -   5        $
��Save��5$      $��5q�67   ���#0078D4
�������
������ $
��10,5q�6�   �� 5%      -   5        $��Cancel��5%      $��5q�6;   ���#0078D4
�������
������ $
��10,5q�6�   5&      5'      5(      