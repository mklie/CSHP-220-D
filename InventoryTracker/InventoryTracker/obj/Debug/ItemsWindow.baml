   M S B A M L   `   `   `  ����K  GInventoryTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InventoryTrackerInventoryTracker  5   	   "    InventoryTracker.ItemsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InventoryTracker     5   	   -   5          � Title$  Items Window��5   	   $	��300��6   $��201.274��6*    J� SnapsToDevicePixels .  � 
ResizeMode$ CanMinimize=�5
   ;    � WindowStartupLocation$ CenterScreen=�6T    � WindowStyle$ ThreeDBorderWindow=�6y    +� FocusedElement 5	   	   ��  �� ElementName$ uxItemN��.��5      � -   5         �Name$ uxGrid��5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Right=�61   ID #:6T   �� 5   
   -   5        
 ��Name$

 uxID��5       �� 
IsReadOnly . $��1��6F   $��0��6V    � Cursor$ No��6c   ��6    �� *ID+.��6o   ��5      �� 5       �� Color# � ��6"   .��5    "   5!      �� 5#   
   $��0��6   $��1��6$   $��Right=�61   	Item #:6V   �� 5$   
   -   5        $
 uxItemN��5$      $��1��6:   $��1��6J   ��6#   �� *ItemN+6Y   �� 5&   
   $��0��6   $��2��6$   $��Right=�61   Description:6[   �� 5'   
   -   5        $
 uxDescription��5'      $��1��6F   $��2��6V   ��6)   �� *Description+6e   �� 5)   
   $��0��6   $��3��6$   $��Right=�61   Price:6U   �� 5*   
   -   5        $
 uxPrice��5*      $��1��6:   $��3��6J   ��6#   �� *Price+6Y   �� 5,   
   $��0��6   $��4��6$   $��Right=�61   Quantity-on-Hand:6`   �� 5-   
   -   5        $
 uxQntyOnHand��5-      $��1��6D   $��4��6T   ��6(   �� *
QntyOnHand+6c   �� 50   
   $��0��6   $��5��6$   $��Right=�61   	SelfCost:6X   �� 51   
   -   5        $
 
uxSelfCost��51      $��1��6@   $��5��6P   ��6&   �� *
SelfCost+6P   �� 53   
   $��0��6   $��6��6$   $��Right=�61   $��0,0,0,31q�6M   TotalValue:6l   �� 54   
   -	   5        $
 uxTotalValue��54       . $��1��6W   $��6��6g   $��0,0,0,31q�6t   $ No��6�   ��6(   �� *
TotalValue+.��6�   ��55      �� 56      $ 	#FFB4B4B4��6"   .��57   "   58      �� 5:   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��6��6>   $��Right=�6K   $��
0,19,0,-10q�6g   .+�5;      �� -
   5         ��Name$ uxAdd��5;      $��10��6%   $��Center=�63   $��10q�6d   .��6p   Add6u   �� 5<      -   5        $ uxCancel��5<      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   5=      5>      5?      