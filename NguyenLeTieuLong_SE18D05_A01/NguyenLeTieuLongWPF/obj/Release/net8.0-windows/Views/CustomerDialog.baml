   M S B A M L   `   `   `  ����   NguyenLeTieuLongWPF.    (NguyenLeTieuLongWPF.Views.CustomerDialog   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Customer Dialog��$	��400��$	��350�� � WindowStartupLocation$ CenterOwner=����#F5F5F5.��� $��20q� � RowDefinitions �� $
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
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��12��$��Customer Details��$��0,0,0,20q�
����������#0078D4$��2q�.���� $��10q�.+��� $��0��$��Customer ID:��$
��Bold"����#0078D4�� $��1�� �� 
IsReadOnly$
 True��$��0,5,0,10q����#E6F0FA���#0078D4$��1q����� *
CustomerID+ �� UpdateSourceTrigger$ PropertyChanged=��� $��2��$��
Full Name:��$
��Bold"����#0078D4�� $��3��$��0,5,0,10q�
����������#0078D4$��1q����� *CustomerFullName+$ PropertyChanged=��� $��4��$��
Telephone:��$
��Bold"����#0078D4�� $��5��$��0,5,0,10q�
����������#0078D4$��1q����� *	Telephone+$ PropertyChanged=��� $��6��$��Email Address:��$
��Bold"����#0078D4�� $��7��$��0,5,0,10q�
����������#0078D4$��1q����� *EmailAddress+$ PropertyChanged=��� $��8��$��	Password:��$
��Bold"����#0078D4G� -    G�Name$ PasswordBox��$��9��$��0,5,0,10q�
����������#0078D4$��1q��� $��10��$��	Birthday:��$
��Bold"����#0078D4(  "System.Windows.Controls.DatePicker  $��11��$��0,5,0,10q�
����������#0078D4$��1q�   SelectedDate �� *CustomerBirthday+$ PropertyChanged=��� $��12�� �� Orientation$ 
Horizontal=�$��Right=�$��5q�.+��� -   $
��Save��$��5q����#0078D4
�������
������ $
��10,5q��� -   $��Cancel��$��5q����#0078D4
�������
������ $
��10,5q�