   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5          KursProject.View.CarView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
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
 True��6<   . �55   "   ��  � �� �	#FFD1EBFF6?   56      58      5:      5;      5<       � DataContext 5=      (   "KursProject.ViewModel.CarViewModel  5>   
   .��5@      � $��15q�6    � RowDefinitions 5A   
   �� 5B      $��4* �6   �� 5C      $��3* �6   .+�5E   
   � $��0��6    5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      	 � ColumnDefinitions	 5M      �� 5N      �� 5O      .+�5Q      �� $��0��6   $��0��6#   $��10q�63   $��3q�6@     PlaceholderTextBoxStyle#��[ 6�   $��18(�6�   

 � Tag$(
 "Введите Марку авто��6�   ��6L   ��  �� Path$ CurrentCar.Marka� �� Mode$ TwoWay=�6�   �� 5R      $��1��6   $��0��6#   $��10q�63   $��3q�6@   #��[ 6�   $��18(�6�   $*
 $Введите Модель авто��6�   ��6L   �� $ CurrentCar.Model�$ TwoWay=�6�   �� 5S      $��2��6   $��0��6#   $��10q�63   $��3q�6@   #��[ 6�   $��18(�6�   $,
 &Введите Году выпуска��6�   ��6L   �� $ CurrentCar.Year_Realize�$ TwoWay=�6�   �� 5V      $��3��6   $��0��6#   $��10q�63   $��3q�6@   #��[ 6�   $��18(�6�   $:
 4Выберите статус доступности��6�   ��6L   �� $ CurrentCar.Reliability�$ TwoWay=�6�   �� 5X      $��0��6   $��1��6$   $��12 10q�5Y       �� DisplayMemberPath$ Price��5]       �� SelectedValuePath$ Id_Price��5^      ��5Z      �� *PrList+ �� SelectedItem 5[      �� *
Id_Price+ �� SelectedValue 5\      �� *CurrentCar.Id_Price+5^      �� 5_      $��1��6   $��1��6#   $��10q�63   $��3q�6@   #��[ 6�   $��18(�6�   $(
 "Введите тип кузова��6�   ��6L   �� $ CurrentCar.Type_Body�$ TwoWay=�6�   �� 5`      $��2��6   $��1��6#   $��10q�63   $��3q�6@   #��[ 6�   $��18(�6�   $&
  Введите Гос номер��6�   ��6L   �� $ CurrentCar.Number_Car�$ TwoWay=�6�   �� 5a      -   5        $��txtBlockMessage��5a      $��4��5b      $��0��6   $��2��6*   
���  ��  
Text_Style#��[ 5d   *   ��6   �� $ Message�6*   � 5f      $��3��6   $��1��6    	 5g      �� 5h      �� 5i      �� 5j      .+�5l      �� $��0��6   $��20(�6)   $
��2 5 q�67   $	��Add��5m   #   ��6   �� *SaveCommand+6#   �� 5o      $��1��6   $��20(�6)   $
��2 5 q�67   ��5p      �� $ DeleteCommand�.��6*   Delete5r      �� 5s      $��2��6   $��20(�6)   $
��2 5 q�67   ��5t   
   �� $ UpdateCommand�.��61   Update5v      5w      5x        5y   
   -   5        $��	dgClients��5y         AutoGenerateColumns$ False��5z      $��6��5{      $��1��5|      $	��5,8q�6   $��3q�6   #��[ 5}      ��5~      �� $ CarList�$ TwoWay=� 63   �� *
CurrentCar+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Car Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� $ Id_Car�  5�      $ Price Id��6%   $
 auto 67    6D   �� $ Id_Price�  5�      $ 
Марка��6%   $
 auto 64    6A   �� $ Marka�  5�      $ Модель��6%   $
 auto 65    6B   �� $ Model�  5�      $ Год выпуска��6%   $
 auto 6:    6G   �� $ Year_Realize�  5�      $) #Статус доступности��6%   $
 auto 6A    6N   �� $ Reliability�  5�      $ тип кузова ��6%   $
 auto 6:    6G   �� $ 	Type_Body�  5�      $ Гос номер��6%   $
 auto 68    6E   �� $ 
Number_Car�5�      5�      5�      