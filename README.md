# Erza

这是集成 Goblin 前端框架，Queen 后端框架，构成的双端开发框架。主要以 .NET/C# 为技术栈设计的框架

### 大致全貌

- ENet 套字节
- MessagePack 协议
- MongoDB 数据库
- Luban 配置
- Yooasset 资源管理
- HybridCLR 代码热更

### [现在开始](#qstart)

### [项目结构](#projectcatalog)

---

### TODO

- 集成 Knight 后台

---

#### <span id="qstart">现在开始</span>

  运行 **`./init.bat`** 快速构建项目。请确保网络通畅，构建过程中需要访问 github.com 如果顺利完成，你将得到两个新目录。分别是 `./goblin/`、`./queen/` 分别对应着前端框架与后端框架。接下来，你还需要进入到   `./goblin/`、`./queen/` 进行细节的配置，包括使用方式，请参考源项目 [Goblin](https://github.com/wantdabo/goblin)、[Queen](https://github.com/wantdabo/goblin)

  ***注意**，配置，包括使用方式，参考源项目的开发文档。由于双端使用，协议配置表是共享的。因此， `./goblin/config/` `./queen/config/` 已经被删除。请使用 `./config/`，`./tools/` 包含但不限协议导出、配置表导出的指令

---

#### 项目结构

```text
├─config
├─queen
├─goblin
├─tools
└─init.bat
```

- **config/** 配置表，使用方式，请参考 [Luban](https://github.com/focus-creative-games/luban)
- **queen/** Queen 框架
- **goblin/** Goblin 框架
- **tools/** 包含但不限协议导出、配置表导出的指令
- **init.bat** Windows 环境下，一键构建项目的 BAT 指令
