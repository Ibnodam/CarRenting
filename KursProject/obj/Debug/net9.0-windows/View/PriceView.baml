   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5           KursProject.View.PriceView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
Page_Style#��[  5
        � 	Resources  5        ModernDataGridStyle �� 
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
 True��6<   . �56   "   ��  � �� �	#FFD1EBFF6?   57      59      5;      5<      5=       � DataContext 5>      *   $KursProject.ViewModel.PriceViewModel  5?   
   .��5A      �  � RowDefinitions 5B   
   �� 5C      $��2* �6   �� 5D      $��2* �6   �� 5E      $��* �6   �� 5F      $��4* �6   .+�5H   
   �� $��0��6   $��3q�6      PlaceholderTextBoxStyle#��[ 6b   $��30(�6�   
	 � Tag$'	 !Введите Стоимость��6�   ��6,   �� 
 �� Path$
 CurrentPrice.Price� �� Mode$ TwoWay=�6�   � 5I   
   $��1��6    � ColumnDefinitions 5J      �� 5K      �� 5L      �� 5M      .+�5O      �� -   5        $��btnAdd��5O      $��Добавить��5P      $	��5,8q�6(   $��3q�65   ��5Q      �� $
 SaveCommand��� 5S      -   5        $��	btnUpdate��5S   %   $��1��6   $��Обновить��5T      $	��5,8q�6)   $��3q�66   ��5U      �� $
 UpdateCommand��� 5W      -   5        $��	btnDelete��5W   %   $��2��6   $��Удалить��5X      $	��5,8q�6'   $��3q�64   ��5Y      �� $
 DeleteCommand�5\      �� 5]   
   -   5        $��txtBlockMessage��5]      $��2��5^      $	��5,8q�5_       �� Padding$ 3q�6!   
���  ��  
Text_Style#��[ 5`   1   ��6   �� $
 Message�61     5b   
   -   5        $��dgEmployees��5b         AutoGenerateColumns$ False��5c      $��6��5d      #��[ 5e      $��0��5f      $	��5,8q�6$   $��3q�61   $��2��6=   ��5g      �� $
 PrList�$ TwoWay=� �� SelectedItem 6D   �� *CurrentPrice+   Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $
 Id_Price�  5k      $ Стоимость��6%   $
 auto 68    6E   �� $
 Price�5m      5n      5o      