   M S B A M L   `   `   `  ����   NguyenLeTieuLongWPF-    'NguyenLeTieuLongWPF.Views.BookingWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Book a Room��$	��600��$	��400�� � WindowStartupLocation$ CenterScreen=����#F5F5F5.��� $��20q� � RowDefinitions �� $
��Auto ��� $��* �.+��� $��0��$��Booking��$��0,0,0,20q�
����������#0078D4$��2q�.���� $��10q�.+��� $��Room:��$
��Bold"����#0078D4�� -    ��Name$ RoomComboBox�� �� DisplayMemberPath$ 
RoomNumber�� �� SelectedValuePath$ RoomID��$��0,5,0,10q�
����������#0078D4$��1q��� $��Start Date:��$
��Bold"����#0078D4(  "System.Windows.Controls.DatePicker  $��0,5,0,10q�
����������#0078D4$��1q�   SelectedDate �� *	StartDate+�� $��	End Date:��$
��Bold"����#0078D4  $��0,5,0,10q�
����������#0078D4$��1q� �� *	EndDate+�� $
��Bold"�
��� � ����� *AvailabilityMessage+�� -   $
��Book��$��0,10,0,0q�$	��100��$��Center=����#0078D4
�������
������ $
��10,5q��� $��1��$��Profile Management��
����������#0078D4$��2q�.���� $��10q�.+��� $��
Full Name:��$
��Bold"����#0078D4�� $��0,5,0,10q�
����������#0078D4$��1q����� *Customer.CustomerFullName+ �� UpdateSourceTrigger$ PropertyChanged=��� $��
Telephone:��$
��Bold"����#0078D4�� $��0,5,0,10q�
����������#0078D4$��1q����� *Customer.Telephone+$ PropertyChanged=��� $��Email:��$
��Bold"����#0078D4�� $��0,5,0,10q�
����������#0078D4$��1q����� *Customer.EmailAddress+$ PropertyChanged=��� $��Booking History:��$
��Bold"����#0078D4�� $ 	BookingID��$��0,5,0,10q�
����������#0078D4$��1q����� *Customer.Bookings+�� -   $��Save Profile��$��0,10,0,0q�$	��100��$��Center=����#0078D4
�������
������ $
��10,5q�