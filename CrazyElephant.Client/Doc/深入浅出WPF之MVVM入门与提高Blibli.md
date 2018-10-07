## 基本常识

- 开发/学习环境
  - VS2010
  - Microsoft Prism
  - Blend SDK
- 必要知识的准备
  - 熟悉 Data Binding、Dependency Property、Dependency Object三个概念
  - 了解WPF中的命令（知道ICommand接口即可，delegate Command代理命令）
  - 熟悉Lambda表达式
- 创建Code Snippet（代码模板）
  - Code Snippet的使用 
    - for for循环
    - prop 属性
    - propfull 属性的完整写法
    - propdp 依赖属性写法
    - ctor 写一个构造函数
    - class 创建一个类
  - Code Snippet的创建
    - Code Snippets Manager
    - 建立一个propn，即一个propfull带一个Notification



## MVVM设计模式详解

- MVVM = Model - View - ViewModel
- 为什么要使用MVVM模式
  - 团队层面：统一思维方式和实现方法
  - 架构层面：稳定，解耦，富有禅意
  - 代码层面：可读，可测，可替换
- 什么是Model（模型驱动开发）Domain Model 域模型
  - 现实世界中对象的抽象结果，建模
- 什么是View和ViewModel
  - View = UI，视图
  - ViewModel = Model for View，视图模型
  - ViewModel与View的沟通
    - 传递数据 -- 数据属性
    - 传递操作 -- 命令属性

问题：

- 一定要使用MVVM吗？（MVVM的适用范围）比如做游戏，就不适用
- 一定要学会MVVM吗？（根据需求商定）
- 什么是“解耦”？（UI与业务逻辑分离，橘子皮原理）



## 案例讲解

- 初阶案例
  - NotificationObject与数据属性
    - ViewModel的基本类
  - DelegateCommand与命令属性
    - Excute的方法通过Action<T>代理绑定具体的命令上
  - View与ViewModel的交互（技术难点）
    - INotifyPropertyChanged数据绑定
    - ICommand命令绑定
  - SimpleMvvmDemo.Client2
    - 三个数据属性，两个命令属性
- 进阶案例
  - 使用Microsoft Prism
    - View和ViewModel的交互方法
  - 餐馆点菜系统Demo

一些使用技巧：

- 如果使用了一个没有using过的类的方法，则在方法处按Alt+Enter或Ctrl+.弹出提示
- ![MVVM 原理图](D:\maidan\doc笔记md\MVVMPrinzip.png)
- CrazyElephant案例
  - 建立xml文件，模拟数据接口
  - 建立Services文件夹，来读取数据
    - 建立IDateService接口，声明一个List<Dish>
    - 建立XmlDataService实现这个接口
    - 建立IOrderService接口
    - 建立MockOrderService实现这个接口
  - 建立DishMenuItemViewModel：NotificationObject，有一个Dish的model对象（也可以用属性copy的方式，对于大型Model，只需要部分），有一个IsSelect依赖属性，135分钟

## 引入Prism的方法

- 6.0以前的Prism已经不推荐使用
- 新的Prism主页地址为 https://www.nuget.org/packages/Prism.Wpf/
- 不再安装软件，而是用NuGet Packge Manager加载
  - Install-Package Prism.Wpf -Version 6.3.0
- github主页地址： https://github.com/PrismLibrary/Prism
- RaisePropertyChanged函数应派生子BindableBase，要引用Prism.Mvvm;









