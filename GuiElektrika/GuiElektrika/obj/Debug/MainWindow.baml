   M S B A M L   `   `   `  ????G  CGuiElektrika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GuiElektrikaGuiElektrika  5   	       GuiElektrika.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GuiElektrika     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         cvs??%   &	        ?? 5
   
   6   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      .+?5   
   ?? $??Pregled elektrike po urah??6   $??24(?65   ?? 5   
   -   5        $??
lstPregled??5       $??1??6   ??5      ??  ?? Source# [  ??5      ?? 5      .R?5      ??  ?? Orientation$ 
Horizontal=?6!   .+?5      ?? $??5q?69   ??6$   ?? *Ura+69   ?? 5      $??5q?5   $   ??5   $   ?? *Moč+ ?? StringFormat$ {0:N2}??5   $   5      5      5      5      5      