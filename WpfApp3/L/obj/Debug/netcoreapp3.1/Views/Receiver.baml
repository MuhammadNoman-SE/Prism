   M S B A M L   `   `   `  ����  L    L.Views.Receiver   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5       � 	Resources 5       �� 
TargetType �� Property �� Value��%{   '��       �� 5   
   " ��6   .�5	      ��  � �� 6'   �� *&$DataContext.SelectedPerson.FirstName+5
      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��Visited times: ��6   �� 5      $��1��6/   ��6   �� *Count+6/   5      �� 5   
   $��1��6   $��Continue Communication?��6     d� 	IsChecked 6B   �� *Show+� 5   
   -   5         �Name$ 
LayoutRoot��5      $��2��6   
�������$��10q�6C    5      �� 5      $	��100 �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5$      �� -   5        	 ��Name$	 listOfPeople��5$      ��6,   �� *People+*  $Microsoft.Xaml.Behaviors.Interaction
   Triggers
 5%      +  %Microsoft.Xaml.Behaviors.EventTrigger  5&         	EventName$ SelectionChanged��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5'      -  'Prism.Interactivity.InvokeCommandAction     Command 64   �� *PersonSelectedCommand+   CommandParameter 6^   �� *SelectedItem+ �� ElementName$ listOfPeople��5(      5*      �� 5+      $��1��6   $��10q�6&   !  Prism.Regions.RegionManager   
RegionName$ PersonDetailsRegion��62   �� 5,      $��2��6   $��Go Back��6"   ��64   �� *GoBackCommand+5-      5/      50      