   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5          KursProject.View.PayView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
Page_Style#��[  5	        � 	Resources  5        ModernDataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value��%�  &	       �� 5   
   "  6,   .�5      ��  � �� �	#FFF0F0F06+   �� 5       � �� �	#FF3333336+   �� 5       � �� �	#FFABADB36,   �� 5       � ��$ 1q�60   �� 5        �@ RowDetailsVisibilityMode$ 	Collapsed=�69   �� 5       � ��$
 True��6>   �� 5       �@ SelectionMode$ Extended=�6.   �� 5       �@ SelectionUnit$ FullRow=�6.   �� 5       �@ AutoGenerateColumns$ False��64   �� 5       �@ HeadersVisibility$ Column=�62   �� 5       �@ CanUserAddRows$ False��6/   �� 5       �@ 
IsReadOnly$
 True��6+   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       � ��$ 5q�6'   �� 5       � ��$ 12(�6)   �� 5       �@ 	RowHeight$ 28Q�6*   �� 5       �@ ColumnHeaderStyle 5       �� 5!      "  6   .�5"      ��  � �� �	#FF0078D767   �� 5#       � ��
 �����67   �� 5$       � ��$
 Bold"�67   �� 5%       � ��$ Center=�6G   �� 5&       � ��$	 5,3q�64   5'      5)      �� 5,       �@ RowStyle 5-      �� 5.      "  6   .�5/      ��  � ��
 �����67    50      P� 51       �@J�IsMouseOver$
 True��6=   . �52   "   ��  � �� �	#FFE6F7FF6?   53      P� 54       �@ 
IsSelected$
 True��6<   . �55   "   ��  � �� �	#FFD1EBFF6?   56      58      5:      5;      5<       � DataContext 5=      +   %KursProject.ViewModel.PayingViewModel  5>   
   .��5@      � $��15q�6    � RowDefinitions 5B   
   �� 5C      $��8* �6   �� 5D      $��1* �6   �� 5E      $��8* �6   .+�5G   
   �� -   5        $��txtBlockMessage��5G      $��1��5H      
���  ��$��15(�5I        
Text_Style#��[ 5J      ��6   �� 	 �� Path$	 Message�6   � 5L   
   $��0��6    5M      �� 5N      $��3* �6    �� 5O      $��3* �6    �� 5P      $��3* �6    �� 5Q      $��3* �6    �� 5R      $��1* �6    
 � ColumnDefinitions
 5T      �� 5U      �� 5V      .+�5X      �� $��0��6   $��0��6$   $��12 10q�5Y       �� DisplayMemberPath$ 
Id_Renting��5]       �� SelectedValuePath$ 
Id_Renting��5^      ��5Z      �� *
RentList+ �� SelectedItem 5[      �� *
Id_Renting+ �� SelectedValue 5\      �� *CurrentPay.Id_Renting+5^      (  "System.Windows.Controls.DatePicker  5_      $��0��6   $��1��6&   $��5q�66      Text 6A   �� $	 CurrentPay.Date_Payment� �� Mode$ TwoWay=��� 5a      $��1��6   $��2��6#   $��0��67   $��5q�6G     PlaceholderTextBoxStyle#��[ 6�   $��18(�6�   
 � Tag$ Введите Сумму��6�   ��6R   �� $	 CurrentPay.Payment�$ TwoWay=�6�   �� 5c      $��2��6   $��0��6#   $��2��63   $��5q�6G   $��3q�6S   #��[ 6�   $��18(�6�   $ Способ оплаты��6�   ��6_   �� $	 CurrentPay.Type_Pay�$ TwoWay=�6�   � 5d      $��0��6   $��2��6#   $��3��67   $��5q�6D   
 5e      �� 5g      �� 5h      .+�5j      �� $��0��6   $��20(�6)   $�� 0 2 2 2q�67   $	��Add��5k   2   ��6   �� *SaveCommand+62   �� 5m      $��1��6   $��20(�6)   $��2 q�67   ��5n      �� $	 DeleteCommand�.��69   Delete5p      5s      5u        5w   
   -   5        $��	dgClients��5w         AutoGenerateColumns$ False��5x      $��6��5y      $��1��5z   	   $	��5,8q�6   $��3q�6&   #��[ 5{      ��5|      �� $	 PayList�$ TwoWay=� 6:   �� *
CurrentPay+   Columns 5}      0  *System.Windows.Controls.DataGridTextColumn  5~      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Paying Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 68   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6E   �� $	 	Id_Paying�  5      $ 
Renting Id��6%   $
 auto 69    6F   �� $	 
Id_Renting�  5�      $ Оплата��6%   $
 auto 65    6B   �� $	 Payment�  5�      $ Дата оплаты��6%   $
 auto 6:    6G   �� $	 Date_Payment�  5�      $ Способ оплаты��6%   $
 auto 6<    6I   �� $	 Type_Pay�  5�      $ Validity_Period��6%   $
 auto 6>    6K   �� $	 Validity_Period�5�      5�      5�      