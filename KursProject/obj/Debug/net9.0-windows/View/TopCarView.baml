   M S B A M L   `   `   `  ����F  BKursProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KursProject.ViewKursProject.View  5      =#clr-namespace:KursProject.ViewModelKursProject.ViewModel  5      !    KursProject.View.TopCarView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:KursProject.View     5      2vm#clr-namespace:KursProject.ViewModel     5         
Page_Style#��[  5        � 	Resources  5        ModernDataGridStyle �� 
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
 True��6<   . �55   "   ��  � �� �	#FFD1EBFF6?   56      58      5:      5;      5<       � DataContext 5=      +   %KursProject.ViewModel.TopCarViewModel  5>   
   .��5@      � .+�5A   
     -   5        $��	dgClients��5A         AutoGenerateColumns$ False��5B      $��6��5C      $��1��5D      $	��5,8q�6   $��3q�6   #��[ 5E      ��5F      �� 	 �� Path$	 TopList�
 �� Mode$
 TwoWay=�   Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Marka��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� $	 Marka�  5J      $ Model��6%   $
 auto 64    6A   �� $	 Model�  5K      $ Id Car��6%   $
 auto 65    6B   �� $	 IdCar�  5L      $ RentalCount��6%   $
 auto 6:    6G   �� $	 RentalCount�5O      5Q      5R      