# MMORPG项目简介
此项目仅为练习项目，代码写的不是很好，注释也不全，很多细节也没有考虑到

后期的时候写的代码很多都只是为了能跑就行，bug可能也有很多，仅供参考！！！

## 项目构建和运行

首先由于服务器使用Mysql存储数据，所以运行服务器的系统必须先安装了Mysql服务，安装的方法可以去网上插

SERVER解决方案下的GameServer即为服务器项目，构建并运行即可启动服务器，会自动创建mmorpg的数据库，并且给你一个默认管理员账号（账号为root，密码为1234567890）

MMORPG即为Unity客户端项目，使用Unity6打开

## 项目配置

数据库的配置在SERVER\GameServer\Db\DbConfig.cs，默认账号密码都为root

网络的配置在SERVER\Common\Network\NetConfig.cs，如果想部署到远程服务器上，就要修改这里面的ServerIpAddress，并且再次构建Common类库

## SERVER - C# 服务器项目

使用C#网络api从0搭建框架，服务器和客户端之间使用protobuf进行通信，使用Mysql存储数据，Serilog作为日志库。

使用excel表格配置地图数据、人物属性、地图上怪物分布情况、掉落物属性等，然后转换为json数据给服务器和客户端解析。

使用aoi算法优化实体之间的交互、检测等逻辑，以及减少同步的网络带宽占用。

### Common类库

此库即为服务器和客户端之间共用的类库

- Data文件夹内存储的就是excel表格，以及对应转换的json和生成的cs文件
- Inventory文件夹为背包的一些通用代码
- Network为通用网络框架
- Proto为protobuf和生成的cs代码
- Tool为一些通用的工具api

## MMORPG - Unity客户端项目

#### 使用QFramework框架，MVC架构

没了XD

## 注意

1.客户端的按钮不要重复点，比如登录按钮，进入游戏按钮什么的，当你点击第一次的时候已经在请求服务器了，因为时间原因没有增加加载框什么的，多次点击就会发送多次请求，可能会报错！

2.客户端里面的资源禁止商用！！！我自己也都是网上找的非正版的！！！

### 开发者

- 客户端主要负责人：fuyouawa
- 服务器主要负责人：yuyuqwq

## 视频介绍

https://www.bilibili.com/video/BV1uNtrefEbn

## 问题

有什么构建和运行的问题，或者项目bug什么的，可以去上面b站视频评论区或者该仓库的issues中提问，不要私信我问。
