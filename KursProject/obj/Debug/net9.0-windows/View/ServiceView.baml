   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5      "    KursProject.View.ServiceView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
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
 True��6<   . �56   "   ��  � �� �	#FFD1EBFF6?   57      59      5;      5<      5=       � DataContext 5>      ,   &KursProject.ViewModel.ServiceViewModel  5?   
   .��5A      �  � RowDefinitions 5B   
   �� 5C      $��1* �6   �� 5D      $��1* �6   �� 5E      $��2* �6   �� 5F      $��* �6   �� 5G      $��4* �6   .+�5I   
   �� $��0��6   $��10q�6   $��3q�6+     PlaceholderTextBoxStyle#��[ 6v   $��18(�6�   
	 � Tag$2	 ,Введите Название Услуги��6�   ��67   �� 
 �� Path$!
 CurrentService.Name_Service� �� Mode$ TwoWay=�6�   �� 5J   
   $��1��6   $��10q�6   $��3q�6+   #��[ 6w   $��18(�6�   $4	 .Введите Стоимость Услуги��6�   ��67   �� $"
 CurrentService.Price_Service�$ TwoWay=�6�   � 5K   
   $��2��6    � ColumnDefinitions 5L      �� 5M      �� 5N      �� 5O      .+�5Q      �� -   5        $��btnAdd��5Q      $��Добавить��5R      $��20(�6!   $	��5,8q�6/   $��3q�6<   ��5S      �� $
 SaveCommand��� 5U      -   5        $��	btnUpdate��5U   3   $��1��6   $��20(�6%   $��Обновить��5V      $	��5,8q�6"   $��3q�6/   ��5W      �� $
 UpdateCommand��� 5Y      -   5        $��	btnDelete��5Y   3   $��2��6   $��20(�6%   $��Удалить��5Z      $	��5,8q�6    $��3q�6-   ��5[      �� $
 DeleteCommand�5^      �� 5_   
   -   5        $��txtBlockMessage��5_      $��3��5`      $	��5,8q�5a       �� Padding$ 3q�6   
���  ��  
Text_Style#��[ 5b   *   ��6   �� $
 Message�6*     5d   
   -   5        $��dgEmployees��5d         AutoGenerateColumns$ False��5e      $��6��5f      #��[ 5g      $��0��5h      $	��5,8q�6   $��3q�6*   $��2��66   ��5i      �� $
 ServList�$ TwoWay=� �� SelectedItem 6?   �� *CurrentService+   Columns 5k      0  *System.Windows.Controls.DataGridTextColumn  5l      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $
 
Id_Service�  5m      $
 Name��6%   $
 auto 63    6@   �� $
 Name_Service�  5n      $ Price��6%   $
 auto 64    6A   �� $
 Price_Service�5p      5q      5r      