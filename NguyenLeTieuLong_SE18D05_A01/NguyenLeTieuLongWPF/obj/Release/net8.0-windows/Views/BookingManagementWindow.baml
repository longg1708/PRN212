   M S B A M L   `   `   `  ����   NguyenLeTieuLongWPF7    1NguyenLeTieuLongWPF.Views.BookingManagementWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Booking Management��$	��500��$	��700�� � WindowStartupLocation$ CenterScreen=����#F5F5F5.��� $��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+���  �� Orientation$ 
Horizontal=�$��5q�.+��� -   $	��Add��$��5q����#0078D4
�������
������ $
��10,5q��� -   $��Update��$��5q����#0078D4
�������
������ $
��10,5q��� -   $��Delete��$��5q����#0078D4
�������
������ $
��10,5q��� -   $��Search��$��5q����#0078D4
�������
������ $
��10,5q��� -    ��Name$ PART_ListBox��$��1��$��5q�
����������#0078D4$��2q����� *
Bookings+���� .R��� $ 
Horizontal=�.+��� $��5q����� *	BookingID+�� $��5q����� *
CustomerID+   CustomerNameConverter �� 	Converter# [   �� ConverterParameter$ CustomerFullName���� $��5q����� *RoomID+  RoomNumberConverter# [ $ 
RoomNumber���� $��5q����� *	StartDate+ �� StringFormat$ d���� $��5q����� *	EndDate+$ d���� $��5q����� *
TotalPrice+$ C���� $��2��$ 
Horizontal=�$��Right=�$��5q�.+��� -   $��Refresh��$��5q����#0078D4
�������
������ $
��10,5q�