   M S B A M L   `   `   `  ����J  FWpfNetCoreRobot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfNetCoreRobot.ViewsWpfNetCoreRobot.Views  5   	   %    WpfNetCoreRobot.Views.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfNetCoreRobot.Views     5   	     � Title$  	ShellView��5   	   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5        $��CoordsListView��5      $��
-10,0,10,0q�6H   $��1��6\   $��1��6l   $��2��6y   ��6)   �� *Coords+ �� View 5      �� 5        �� AllowsColumnReorder$
 true��6    �� ColumnHeaderToolTip$ X Coord��5!      .P�5"      �� $��X Coord��6%    �� Width$	 100��66    �� CellTemplate 5#      �� 5$      .R�5%   "   �� $
��test��6,   ��5&   ,   ��  �� Path$ X�5'      5)      �� 5*      $��Y Coord��5,      $	 100��6(   	 �� DisplayMemberBinding	 5*   %   �� $ Y�5,   (   �� 5-      $
��Pole��5/      $	 100��6%   	 5-   %   �� $
 Pole�5/   %   50      52      �� 53   
   -   5        $
��Move��53      $��1��6   $��3��6-   $��30��6:   $	��110��6F   $
��Move��6R   $
��Left=�6a   �� 54   
   -   5        $
��Left��54      $��2��6   $��3��6-   $��30��6:   $	��110��6F   $
��Left��6R   $
��Left=�6a   �� 55   
   -   5        $��Right��55      $��3��6   $��3��6.   $��30��6;   $	��110��6G   $��Right��6S   $
��Left=�6c   �� 56   
   -   5        $��CommandsListView��56      $��
-10,0,10,0q�6U   $��1��6i   $��5��6y   $��1��6�   ��6+   �� *CommandsToProcess+ 57      �� 58      $
 true��6   $ X Coord��59      .P�5:      �� $��Command��6%   $	 150��66    5;      �� 5<      .R�5=   "   �� $��CommandTextBlock��6,   ��5>   ,   �� $ CommandToRun�5?      5A      5B      5D      �� 5E   
   -   5        $��TextCommand��5E      $��1��6%   $��7��65   $��1��6B   �� 5F   
   -   5        $��EnterCommand��5F      $��2��6%   $��7��65   $��30��6B   $	��110��6N   $��Add Command��6Z   $
��Left=�6p   �� 5G   
   -   5        $��RunAllCommands��5G      $��1��6'   $��9��67   $��30��6D   $	��110��6P   $��Run all commands��6\   $
��Left=�6w   5H      5I      