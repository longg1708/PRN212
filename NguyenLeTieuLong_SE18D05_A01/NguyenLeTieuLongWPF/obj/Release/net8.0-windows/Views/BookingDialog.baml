   M S B A M L   `   `   `  ����   NguyenLeTieuLongWPF-    'NguyenLeTieuLongWPF.Views.BookingDialog   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Booking Dialog��$	��400��$	��300�� � WindowStartupLocation$ CenterOwner=����#F5F5F5.��� $��20q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��10��$��Booking Details��$��0,0,0,20q�
����������#0078D4$��2q�.���� $��10q�.+��� $��0��$��Booking ID:��$
��Bold"����#0078D4�� $��1�� �� 
IsReadOnly$
 True��$��0,5,0,10q����#E6F0FA���#0078D4$��1q����� *	BookingID+ �� UpdateSourceTrigger$ PropertyChanged=��� $��2��$��Customer ID:��$
��Bold"����#0078D4�� -    ��Name$ CustomerComboBox��$��3�� �� DisplayMemberPath$ CustomerFullName�� �� SelectedValuePath$ 
CustomerID��$��0,5,0,10q�
����������#0078D4$��1q��� $��4��$��Room ID:��$
��Bold"����#0078D4�� -   $ RoomComboBox��$��5��$ 
RoomNumber��$ RoomID��$��0,5,0,10q�
����������#0078D4$��1q��� $��6��$��Start Date:��$
��Bold"����#0078D4(  "System.Windows.Controls.DatePicker  $��7��$��0,5,0,10q�
����������#0078D4$��1q�   SelectedDate �� *	StartDate+$ PropertyChanged=��� $��8��$��	End Date:��$
��Bold"����#0078D4  $��9��$��0,5,0,10q�
����������#0078D4$��1q� �� *	EndDate+$ PropertyChanged=��� $��10��	 �� Orientation$	 
Horizontal=�$��Right=�$��5q�.+��� -   $
��Save��$��5q����#0078D4
�������
������ $
��10,5q��� -   $��Cancel��$��5q����#0078D4
�������
������ $
��10,5q�