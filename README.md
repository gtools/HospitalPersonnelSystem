# 更新说明

## 1. 新建并连接存储库

1. 生成私有公有钥匙。

``` cmd
ssh-keygen -t rsa -C "gtool@vip.qq.com"
```

> 目录为父级.ssh/id_rsa

2. 在GitHub设置添加密钥

3. 在当前项目目录，连接GitHub。

``` cmd
git config --global user.name "GTool"
git config --global user.email "gtool@vip.qq.com"
git init
git remote add origin git@github.com:gtools/gt.git
git add .
git commit -a -m "第一次提交"
git push -u origin master
```

> 如果报错强制提交

``` cmd
git push -u origin master -f
```

## 2. 生成私有公有钥匙


