   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5      !    KursProject.View.ClientView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
Page_Style#��[  5
        � 	Resources  5        ModernDataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value��%�  &	       �� 5   
   "  6,   .�5      ��  � �� �	#FFF0F0F06+   �� 5       � �� �	#FF3333336+   �� 5       � �� �	#FFABADB36,   �� 5       � ��$ 1q�60   �� 5        �@ RowDetailsVisibilityMode$ 	Collapsed=�69   �� 5       � ��$
 True��6>   �� 5       �@ SelectionMode$ Extended=�6.   �� 5       �@ SelectionUnit$ FullRow=�6.   �� 5       �@ AutoGenerateColumns$ False��64   �� 5       �@ HeadersVisibility$ Column=�62   �� 5       �@ CanUserAddRows$ False��6/   �� 5       �@ 
IsReadOnly$
 True��6+   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       � ��$ 5q�6'   �� 5       � ��$ 12(�6)   �� 5       �@ 	RowHeight$ 28Q�6*   �� 5        �@ ColumnHeaderStyle 5!      �� 5"      "  6   .�5#      ��  � �� �	#FF0078D767   �� 5$       � ��
 �����67   �� 5%       � ��$
 Bold"�67   �� 5&       � ��$ Center=�6G   �� 5'       � ��$	 5,3q�64   5(      5*      �� 5-       �@ RowStyle 5.      �� 5/      "  6   .�50      ��  � ��
 �����67    51      P� 52       �@J�IsMouseOver$
 True��6=   . �53   "   ��  � �� �	#FFE6F7FF6?   54      P� 55       �@ 
IsSelected$
 True��6<   . �56   "   ��  � �� �	#FFD1EBFF6?   57      59      5;      5<      5=       � DataContext 5>      +   %KursProject.ViewModel.ClientViewModel  5?   
   .��5A      � $��15q�6    � RowDefinitions 5C   
   �� 5D      $��8* �6   �� 5E      $��1* �6   �� 5F      $��8* �6   .+�5H   
   �� -   5        $��txtBlockMessage��5H      $��1��5I      
���  ��$��15(�5J        
Text_Style#��[ 5K      ��6   �� 	 �� Path$	 Message�6   � 5M   
   $��0��6    5N      �� 5O      $��3* �6    �� 5P      $��3* �6    �� 5Q      $��3* �6    �� 5R      $��3* �6    �� 5S      $��1* �6    
 � ColumnDefinitions
 5U      �� 5V      �� 5W      .+�5Y      �� $��0��6   $��0��6#   $��5q�63     PlaceholderTextBoxStyle#��[ 6t   $��18(�6�   
 � Tag$ Введите ФИО��6�   ��6?   �� $	 CurrentClient.FIO� �� Mode$ TwoWay=�6�   �� 5Z      $��1��6   $��0��6#   $��5q�63   #��[ 6v   $��18(�6�   $ Введите Email��6�   ��6>   �� $	 CurrentClient.Email�$ TwoWay=�6�   �� 5[      $��2��6   $��0��6#   $��5q�63   #��[ 6{   $��18(�6�   $. (Введите стаж вождения��6�   ��6?   �� $	 CurrentClient.Experience�$ TwoWay=�6�   �� 5\      $��3��6   $��0��6#   $��5q�63   #��[ 6   $��18(�6�   $3 -Введите Срок действия ВУ��6�   ��6>   �� $#	 CurrentClient.Validity_Period�$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5^      $��0��6   $��1��6&   $��5q�66      SelectedDate 6A   �� $	 CurrentClient.BirthDate�$ TwoWay=��� 5_      $��1��6   $��1��6#   $��5q�63   $��3q�6?   #��[ 6�   $��18(�6�   $% Введите номер ВУ ��6�   ��6K   �� $"	 CurrentClient.Number_License�$ TwoWay=�6�   �� 5`      $��2��6   $��1��6#   $��5q�63   $��3q�6?   #��[ 6�   $��18(�6�   $K EВведите Количество арендованных авто��6�   ��6K   �� $	 CurrentClient.Count_Car�$ TwoWay=�6�   � 5a      $��1��6   $��3��6#   $��5q�60   
 5b      �� 5c      �� 5d      �� 5e      .+�5g      �� $��0��6   $��20(�6)   $�� 0 2 2 2q�67   $	��Add��5h   2   ��6   �� *SaveCommand+62   �� 5j      $��1��6   $��20(�6)   $��2 q�67   ��5k      �� $	 DeleteCommand�.��69   Delete5m      �� 5n      $��2��6   $��20(�6)   $��2 2 0 2q�67   ��5o      �� $	 UpdateCommand�.��6@   Update5q      5s      5u        5w   
   -   5        $��	dgClients��5w      #��[ 5x         AutoGenerateColumns$ False��5y      $��6��5z      $��1��5{      $	��5,8q�5|      $��3q�5}      ��5~      �� $	 ClList�$ TwoWay=� �� SelectedItem 5      �� *CurrentClient+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Client Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 68   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6E   �� $	 	Id_Client�  5�      $	 FIO��6%   $
 auto 62    6?   �� $		 FIO�  5�      $ Email��6%   $
 auto 64    6A   �� $	 Email�  5�      $ 
Experience��6%   $
 auto 69    6F   �� $	 
Experience�  5�      $ Validity_Period��6%   $
 auto 6>    6K   �� $	 Validity_Period�  5�      $ 	Count_Car��6%   $
 auto 68    6E   �� $	 	Count_Car�  5�      $ Number_License��6%   $
 auto 6=    6J   �� $	 Number_License�  5�      $ Status��6%   $
 auto 65    6B   �� $	 Status�5�      5�      5�      