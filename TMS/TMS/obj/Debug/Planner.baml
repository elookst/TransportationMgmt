   M S B A M L   `   `   `  ����>  :TMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TMSTMS  5   	       TMS.Planner   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:TMS     5   	     � Title$  Planner��5   	   $
��1512��6   $
��1150��6'   
����İ�.��5	      � $��0,0,-617,-1q�6   .+�5
   
   �� -   5         ��Name$ LogOut��5
      $��Log Out��6!   $��1��63   $
��Left=�6C   $��1650,10,0,0q�6^   $	��Top=�6s   $��75��6�   $��14(�6�   $
��Bold"�6�   6�   �� 5   
   $��Active Orders��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   $
��Bold"�6n   $��14(�6�    J� RenderTransformOrigin$ 
0.548,1.07&�6�   $	��910��6�   ���	#FFFFBFBF6�   � 5   
   $
��Left=�6   $	��310��6*   $	��Top=�67   $	��920��6O   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dataGridCustomers��5   d      AutoGenerateColumns .  $
��Left=�63   $��10,45,-20,40q�6N   $	��910��6}      CanUserResizeRows .  ��6�   ��  �� Path$ LoadDataBinding�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6\   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� $ orderID�6g     5      $ Client Name��6N   $	 120 6c   	 . 
 6)   �� $ Client_Name�6o     5      $ Job Type��6K   $ 70 6]   	 . 
 6)   �� $ Job_Type�6h     5      $ Quantity��6K   $ 80 6]   	 . 
 6)   �� $ Quantity�6h     5      $ Origin��6I   $	 120 6Y   	 . 
 6)   �� $ Origin�6e     5      $ Destination��6N   $	 120 6c   	 . 
 6)   �� $ Destination�6o     5      $ Van Type��6K   $ 70 6]   	 . 
 6)   �� $ Van_Type�6h     5      $ Order Status��6O   $	 120 6e   	 . 
 6)   �� $ order_status�6q     5      $ Create_Time��6N   $ 70 6c   	 . 
 6)   �� $ create_time�6n     5      $ 
Carrier ID��6L   $ 70 6`   	 . 
 6)   �� $ 	carrierID�6k   5      �� 5      -   5        $��btnloaddata��5   k   $
��Load��6   $��75��6$   $��25��6/   $
��Left=�6;   $��845,285,0,0q�6V   $	��Top=�6~   $��14(�6�   $
��Bold"�6�   5      �� 5   
   $��Update Orders��6   $
��Left=�6(   $��
10,330,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   $��14(�6�   $ 
0.548,1.07&�6�   $	��910��6�   ���	#FFFFBFBF6�   �� 5   
   $��Order ID��6   $
��Left=�6#   $��
10,375,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   $��14(�6|   $ 
0.548,1.07&�6�   ��5       �� 5!      5#      �� 5$   
   $��Carrier��6   $
��Left=�6"   $��10,455,0,-27q�6=   $	��Top=�6S   $
��Bold"�6k   $��14(�6}   $ 
0.548,1.07&�6�   ��5%      �� 5&      5(      �� 5)   
   $��Order Status��6   $
��Left=�6'   $��10,535,0,-27q�6B   $	��Top=�6X   $
��Bold"�6p   $��14(�6�   $ 
0.548,1.07&�6�   ��5*      �� 5+      5-      �� 5.   
   $��Process Time��6   $
��Left=�6'   $��375,375,0,0q�6B   $	��Top=�6W   $
��Bold"�6o   $��14(�6�   $ 
0.548,1.07&�6�   ��5/      �� 50      52      �� 53   
   -   5         ��Name$ orderID��53      $
��Left=�6#   $��23��6>   $��125,375,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��180��6�   �� 54   
   -   5        $��CarrierName��54      $	��180��6&   $��23��62   $	��Top=�6>   $
��Left=�6V   $��125,455,0,-26q�6q   .@�55      �� $��Planet Express��6   66   �� 56      $��
Schooner's��6   62   �� 57      $��Tillman Transport��6   69   �� 58      $��We Haul��6   6/   59      &   System.Windows.Controls.Calendar  5:   
   -   5          Name$ orderProcessingDate��5:      $	��Top=�60   $
��Left=�6H   $��490,375,0,0q�6c      CalendarDayButtonStyle 5;      �� 5<       �� 
TargetType:  4System.Windows.Controls.Primitives.CalendarDayButton"  6   .�5=      ��  �� Property �@J�IsHitTestVisible �� Value . 69   5>      5@      �� 5A   
   -   5        $��OrderStatusCombo��5A      $	��180��6+   $��23��67   $	��Top=�6C   $
��Left=�6[   $��125,535,0,0q�6v   .@�5B      �� $	��New��6   6+   �� 5C      $��
Processing��6   62   �� 5D      $��Complete��6   60   5E      �� 5F   
   -   5        $��Update Order Status��5F      $
��Left=�6/   $	��Top=�6J   $	��145��6b   $��775,385,0,0q�6n   $��14(�6�   $
��Bold"�6�   6�   �� 5H   
   $��	Add Trips��6   $
��Left=�6$   $��
10,595,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   $��14(�6}   $ 
0.548,1.07&�6�   $	��910��6�   ���	#FFFFBFBF6�   �� 5I   
   $��Trip Status��6   $
��Left=�6&   $��10,650,0,-27q�6A   $	��Top=�6W   $
��Bold"�6o   $��14(�6�   $ 
0.548,1.07&�6�   ��5J      �� 5K      5M      �� 5N   
   -	   5        $��Add Trip��5N      $
��Left=�6$   $	��Top=�6?   $	��145��6W   $��775,650,0,0q�6c   $��14(�6x   $
��Bold"�6�   6�   �� 5O   
    �� Orientation$ Vertical=�6   $	��400��6,   $	��400��68   $
��Left=�6E   $��
10,700,0,0q�6`   $	��Top=�6t   .+�5P      �� -
   5         ��Name$ orderStatusDisplay��5P      $��14(�5Q      $
��Bold"�5R      $
��Wrap=�5S      
���   �5T      5U      �� 5V   
   $��Invoices��6   $
��Left=�6#   $��975,10,-126,0q�6>   $	��Top=�6U   $
��Bold"�6m   $��14(�6   $ 
0.548,1.07&�6�   $	��630��6�   ���	#FFFFBFBF6�   � 5W   
   $
��Left=�6   $	��310��6*   $	��Top=�67   $	��630��6O   .+�5X        -   5        $��dataGridInvoices��5X   g    .  $
��Left=�63   $��975,45,-1245,45q�6N   $	��630��6    .  ��6�   �� $ LoadDataBinding� 5Y        5Z      $ 
Invoice ID��6L   $ 70 6`   	 . 
 6)   �� $ 	invoiceID�6k     5[      $ order ID��6J   $ 70 6\   	 . 
 6)   �� $ orderID�6g     5\      $ Invoice Date��6O   $	 100 6e   	 . 
 6)   �� $ invoice_date�6q     5]      $ Amount��6I   $ 80 6Y   	 . 
 6)   �� $ amount�6d     5^      $ Distance��6K   $	 120 6]   	 . 
 6)   �� $ distance�6i     5_      $ 	Surcharge��6L   $	 120 6_   	 . 
 6)   �� $ 	surcharge�6k     5`      $ 	Trip Time��6L   $ 70 6_   	 . 
 6)   �� $ 	trip_time�6j   5b      �� 5c      -   5        $��btnloadinvoice��5c   y   $��Load Invoices��6   $	��100��6-   $��25��69   $
��Left=�6E   $��1505,285,-975,0q�6`   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   5d      5e      5f      