# Sprite Atlas的使用

 1. 新版的Sprite Atlas使用：Unity -> Edit-> Project Settings -> Editor-> Sprite Packer 选择 Sprite Atlas V1 - Always Enabled .


 2. 选择右键Create -> Sprite-> Sprite Atlas.
 3. 设置Objects for Packing的图元.
 4. 关于AB的结合使用，同一个图集内的所有图元打包时都要放在同一个AssetBundle中.
 5. AB的引用还是可以通过散图的方式去引用.
 6. 共用的持久型的资源单独打图集和AB包.

# 没有打图集的结果显示如下：
测试DrawCall展示

![DrawCall显示](%E6%B2%A1%E6%89%93%E5%9B%BE%E9%9B%86%E7%9A%84DrawCall.png)

测试包体大小
![包体大小](%E6%B2%A1%E6%89%93%E5%9B%BE%E9%9B%86%E7%9A%84apk%E7%9A%84%E5%A4%A7%E5%B0%8F.png)

测试包图片资源在Apk中的存储的方式
![图片存储方式](%E6%B2%A1%E6%89%93%E5%9B%BE%E9%9B%86apk%E8%B5%84%E6%BA%90%E5%9B%BE%E7%89%87%E5%AD%98%E5%82%A8%E7%9A%84%E5%BD%A2%E5%BC%8F.png)


# 打图集的结果显示如下：
测试DrawCall展示

![DrawCall显示](%E6%89%93%E5%9B%BE%E9%9B%86%E7%9A%84DrawCall.png)

测试包体大小
![包体大小](%E6%89%93%E5%9B%BE%E9%9B%86Apk%E7%9A%84%E5%A4%A7%E5%B0%8F.png)

测试包图片资源在Apk中的存储的方式
![图片存储方式](%E6%89%93%E5%9B%BE%E9%9B%86apk%E8%B5%84%E6%BA%90%E5%9B%BE%E7%89%87%E5%AD%98%E5%82%A8%E7%9A%84%E5%BD%A2%E5%BC%8F%E6%95%B4%E5%9B%BE.png)



