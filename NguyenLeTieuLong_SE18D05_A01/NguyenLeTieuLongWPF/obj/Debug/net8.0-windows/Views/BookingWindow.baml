   M S B A M L   `   `   `  ����  NguyenLeTieuLongWPF-    'NguyenLeTieuLongWPF.Views.BookingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Book a Room��5   	   $	��700��6   $	��400��6*    � WindowStartupLocation$ CenterScreen=�66   ���#F5F5F5.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Booking��6    $��0,0,0,20q�61   
����������#0078D4$��2q�6l   .��5      �� $��10q�6   .+�5      �� $��Room:��6   $
��Bold"�6(   ���#0078D46:   �� 5      -   5         ��Name$ RoomComboBox��5       �� DisplayMemberPath$ 
RoomNumber��61    �� SelectedValuePath$ RoomID��6P   $��0,5,0,10q�6�   
����������#0078D4$��1q�6�   �� 5      $��Start Date:��6   $
��Bold"�6.   ���#0078D46@   (  "System.Windows.Controls.DatePicker  5      $��0,5,0,10q�6@   
����������#0078D4$��1q�6{      SelectedDate 6   �� *	StartDate+6{   �� 5      $��	End Date:��6   $
��Bold"�6,   ���#0078D46>     5      $��0,5,0,10q�6>   
����������#0078D4$��1q�6y    6   �� *	EndDate+6y   �� 5      $
��Bold"�6@   
��� � ���6   �� *AvailabilityMessage+6R   �� 5      -   5        $
��Book��5      $��0,10,0,0q�6;   $	��100��6M   $��Center=�6Y   ���#0078D4
�������
������ $
��10,5q�6�   5      5      �� 5   
   $��1��6   $��Profile Management��6    
����������#0078D4$��2q�6e   .��5      �� $��10q�6   .+�5      �� $��
Full Name:��6   $
��Bold"�6-   ���#0078D46?   �� 5      $��0,5,0,10q�6j   
����������#0078D4$��1q�6�   ��6   �� *Customer.CustomerFullName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��
Telephone:��6   $
��Bold"�6-   ���#0078D46?   �� 5      $��0,5,0,10q�6c   
����������#0078D4$��1q�6�   ��6   �� *Customer.Telephone+$ PropertyChanged=�6�   �� 5       $��Email:��6   $
��Bold"�6)   ���#0078D46;   �� 5!      $��0,5,0,10q�6f   
����������#0078D4$��1q�6�   ��6   �� *Customer.EmailAddress+$ PropertyChanged=�6�   �� 5"      $��Booking History:��6   $
��Bold"�63   ���#0078D46E   �� 5#      $ 	BookingID��6D   $��0,5,0,10q�6b   
����������#0078D4$��1q�6�   ��6   �� *Customer.Bookings+6�   �� 5$      -   5        $��Save Profile��5$      $��0,10,0,0q�6J   $	��100��6\   $��Center=�6h   ���#0078D4
�������
������ $
��10,5q�6�   5%      5&      5'      5(      