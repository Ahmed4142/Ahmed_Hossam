   M S B A M L   `   `   `  ����B  >p_tasks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:p_tasksp_tasks  5   	       p_tasks.view_tasks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:p_tasks     5   	     � Title$  
view_tasks��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ nameemp��5
      $��Employee name��6!   $��30(�69   $
��Bold"�6G   $
��Left=�6Y   $��
296,10,0,0q�6t   $	��Top=�6�   $	��244��6�   �� 5   
   ���	#FFB1B1B1$��pending /in progress��6'   $��16(�6F   $
��Bold"�6T   $
��Left=�6f   $��
105,60,0,0q�6�   $	��Top=�6�   $	��172��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgtasksfrist��5      $��105,110,94,242q�6'      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ task Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	task_id+  5      $ Title��6%    64   �� *title+  5      $ Description��6%    6:   �� *descriptions+  5      $ statues��6%    66   �� *	statues+5      �� 5   
   $
��Bold"�6   $��Task:��6"   $
��Left=�62   $��104,265,0,0q�6M   $	��Top=�6b   $��30��6z   $��56��6�   �� 5   
   -   5         ��Name$ 	taskidtxt��5      $
��Bold"�6%   $
��Left=�67   $��160,265,0,0q�6R   $	��Top=�6g   $��52��6   $��24��6�   �� 5   
   $
��Bold"�6   $��Status:��6"   $
��Left=�64   $��314,268,0,0q�6O   $	��Top=�6d   $��30��6|   $��56��6�   �� 5   
   -   5         ��Name$ 	cmbstatus��5       �� DisplayMemberPath$ statues��6&   	 �� SelectedValuePath$	 task_id��6B   $
��Left=�6^   $��386,270,0,0q�6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $
��save��5      $
��Left=�6    $��633,268,0,0q�6;   $	��Top=�6P   $��62��6h   $��31��6s   6   �� 5   
   ���	#FFB1B1B1$��16(�6'   $��
Compoleted��65   $
��Bold"�6J   $
��Left=�6\   $��105,300,0,0q�6w   $	��Top=�6�   $	��102��6�     5   
   -   5        $��
dgtasksend��5      $��105,336,94,39q�6%    .   5        5      $ task Id��6%    66   �� *	task_id+  5      $ Title��6%    64   �� *title+  5      $ Description��6%    6:   �� *descriptions+  5       $ statues��6%    66   �� *	statues+5"      5#      5$      