   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5      ?$clr-namespace:KursProject.ConvertersKursProject.Converters  5      "    KursProject.View.RentingView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5      5conv$clr-namespace:KursProject.Converters     5         
Page_Style#��[  5
        � 	Resources  5        ModernDataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value0   *KursProject.Converters.FromServiceIdTOName  ServiceConverter   Services��%�  &	       &	 �    �� 5   
   "  6,   .�5      ��  � �� �	#FFF0F0F06+   �� 5       � �� �	#FF3333336+   �� 5       � �� �	#FFABADB36,   �� 5       � ��$ 1q�60   �� 5        �@ RowDetailsVisibilityMode$ 	Collapsed=�69   �� 5       � ��$
 True��6>   �� 5       �@ SelectionMode$ Extended=�6.   �� 5       �@ SelectionUnit$ FullRow=�6.   �� 5       �@ AutoGenerateColumns$ False��64   �� 5       �@ HeadersVisibility$ Column=�62   �� 5       �@ CanUserAddRows$ False��6/   �� 5       �@ 
IsReadOnly$
 True��6+   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       � ��$ 5q�6'   �� 5       � ��$ 12(�6)   �� 5       �@ 	RowHeight$ 28Q�6*   �� 5!       �@ ColumnHeaderStyle 5"      �� 5#      "  6   .�5$      ��  � �� �	#FF0078D767   �� 5%       � ��
 �����67   �� 5&       � ��$
 Bold"�67   �� 5'       � ��$ Center=�6G   �� 5(       � ��$	 5,3q�64   5)      5+      �� 5.       �@ RowStyle 5/      �� 50      "  6   .�51      ��  � ��
 �����67    52      P� 53       �@J�IsMouseOver$
 True��6=   . �54   "   ��  � �� �	#FFE6F7FF6?   55      P� 56       �@ 
IsSelected$
 True��6<   . �57   "   ��  � �� �	#FFD1EBFF6?   58      5:      5=      5>        5?   
    6<   �� *
ServList+5A       � DataContext 5B      ,   &KursProject.ViewModel.RentingViewModel  5C   
   .��5E      � $��15q�6   	 � RowDefinitions	 5F   
   �� 5G      $��4* �6   �� 5H      $��2* �6   .+�5J   
   � $��0��6   	 5K      �� 5M      �� 5N      �� 5O      �� 5P      �� 5Q      �� 5R      
 � ColumnDefinitions
 5T      �� 5U      �� 5V      .+�5X      �� $��0��6   $��0��6$   $��12 10q�5Y       �� DisplayMemberPath$ Model��5]       �� SelectedValuePath$ Id_Car��5^      ��5Z      �� *	CarList+ �� SelectedItem 5[      �� *Id_Car+ �� SelectedValue 5\      �� *CurrentRent.Id_Car+5^      (  "System.Windows.Controls.DatePicker  5_      $��12 10q�6   $��1��6)   $��1��66      IsTodayHighlighted$
 True��5b         SelectedDateFormat$ Short=�5c         SelectedDate 5`      ��  �� Path$ CurrentRent.Data_Return� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5c        5d      $��12 10q�6   $��1��6(   $��0��65   $
 True��5g      $ Short=�5h       5e      �� $ CurrentRent.Data_Rent�$ TwoWay=�$ PropertyChanged=�5h      �� 5i      $��0��6   $��1��6$   $��12 10q�5j      $	 FIO��5n      $ 	Id_Client��5o      ��5k      �� *
ClientList+ 5l      �� *	Id_Client+ 5m      �� *CurrentRent.Id_Client+5o      �� 5q      $��2��6   $��0��6$   $��12 10q�5r      $ Name_Service��5v      $ 
Id_Service��5w      ��5s      �� *
ServList+ 5t      �� *Id_Service1+ 5u      �� *CurrentRent.Id_Service1+5w      �� 5y      $��2��6   $��1��6$   $��12 10q�5z      $ Name_Service��5~      $ 
Id_Service��5      ��5{      �� *
ServList+ 5|      �� *Id_Service2+ 5}      �� *CurrentRent.Id_Service2+5      �� 5�      $��3��6   $��0��6$   $��12 10q�5�   	   $ Name_Service��5�   	   $ 
Id_Service��5�   	   ��5�   	   �� *
ServList+ 5�   	   �� *Id_Service3+ 5�   	   �� *CurrentRent.Id_Service3+5�   	   �� 5�      $��3��6   $��1��6#   $��10q�63     PlaceholderTextBoxStyle#��[ 6y   $��18(�6�   
 � Tag$ Дни Аренды��6�   ��6?   �� $ CurrentRent.RentalDays�$ TwoWay=�6�   �� 5�      -   5        $��txtBlockMessage��5�      $��5��5�   	   $��0��6   $��2��6&   $��10(�6;   
���  ��  
Text_Style#��[ 5�   '   ��6	   �� $ Message�6'   � 5�      $��4��6   $��0��6    $��2��60   
 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��20(�6)   $��10q�67   $	��Add��5�   #   ��6   �� *SaveCommand+6#   �� 5�      $��1��6   $��20(�6)   $��10q�67   ��5�      �� $ DeleteCommand�.��6*   Delete5�      5�      5�        5�   
   -   5        $��	dgClients��5�         AutoGenerateColumns$ False��5�      $��6��5�      #��[ 5�      $��1��5�      $	��5,8q�6   $��3q�6   ��5�      �� $ RentList�$ TwoWay=� 64   �� *CurrentRent+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Renting Id��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$
 auto	 69   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6F   �� $ 
Id_Renting�  5�      $ 	Client Id��6%   $
 auto	 68    6E   �� $ 	Id_Client�  5�      $ Car Id��6%   $
 auto	 65    6B   �� $ Id_Car�  5�      $- 'Дата выдачи на аренду��6%   $
 auto	 6D    6Q   �� $ 	Data_Rent�  5�      $ Дата возврата��6%   $
 auto	 6<    6I   �� $ Data_Return�  5�      $ Колво дней��6%   $
 auto	 69    6F   �� $ 
RentalDays�  5�      $% Стоимость Аренды��6%   $
 auto	 6?    6L   �� $ Amount�  5�      $ Услуга 1��6%   $
 auto	 67    6I   �� $ Id_Service1�  5�      $ Услуга 2��6%   $
 auto	 67    6D   �� $ Id_Service2�  5�      $ Услуга 3��6%   $
 auto	 67    6D   �� $ Id_Service3�5�      5�      5�      