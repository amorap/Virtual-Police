   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    VirtualPolice(   "VirtualPolice.UI_ConsultarPlanning   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  Consultar Planning��5   	   $��517.429��6$   $��780.067��65    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6t   ��5      �� 5   
    �� ImageSource$ Images/FondoApp.jpg��6    j� Stretch$ UniformToFill=�67   .��5	      � .+�5
   
   �� -   5        $��Imprimir��5
      $
��Left=�6$   $��
10,333,0,0q�6?   $	��Top=�6S   $	��179��6k   6w   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ MonthlyCalendar��5         SelectionMode$ SingleRange=�5      $
��Left=�5      $��
10,152,0,0q�6   $	��Top=�63   �� 5   
   $��Agente:��6   $
��Left=�6"   $��
197,50,0,0q�6=   $	��Top=�6Q   $
��Bold"�6i   �� 5   
   $
��DNI:��6   $
��Left=�6   $��
197,25,0,0q�6:   $	��Top=�6N   $
��Bold"�6f   �� 5   
   -   5         ��Name$ 
FotoAgente��5      $
��Left=�6$   $	��137��6?   $��	10,10,0,0q�6L   $	��Top=�6_   $	��103��6w    J� RenderTransformOrigin$ 	0.49,0.52&�6�   � 5   
   .+�5      �� -   5        	 ��Name$	 	ListView1��5      $
��Left=�6*   $	��377��6E   $��
210,88,0,0q�6R   $	��Top=�6f   $	��548��6~   
 �� View
 5      �� 5       �� AllowsColumnReorder . .P�5      �� $	��Dia��6)    �� Width$ 80��5   B    �� DisplayMemberBinding 6   �� *Dia+6B   �� 5      $��Horas ��6)   $	 140��5   D    6   �� *Horas+6D   �� 5      $��Tipo Actividad��6)   $	 133��5   C    6   �� *Tipo+6C   �� 5      $��Descripción��6)   $	 186��5   J    6   �� *Descripcion+6J   5      5       5!      �� 5"   
   -   5         ��Name$ 	lb_nombre��5"      $�� ��6#   $
��Left=�6.   $��
304,50,0,0q�6I   $	��Top=�6]   $	��425��6u   �� 5#   
   -   5        $ lb_dni��5#      $�� ��6    $
��Left=�6+   $��
304,25,0,0q�6F   $	��Top=�6Z   $	��387��6r   5%      5&      