# UnityGithubPackageExample
Unity package example with Github Packages

## Usage

### Example Package Installation
#### Create `.upmconfig.toml`
- https://docs.unity3d.com/Manual/upm-config.html#upmconfigUser

#### Create an access token for GitHub Packages
- https://github.com/settings/tokens
- `read:packages` is only required

#### Add the access token to .upmconfig.toml

```
[npmAuth."https://npm.pkg.github.com/@tsgcpp"]
token = "<ACCESS TOKEN>"
alwaysAuth = true
```

#### Add the package name to manifest.json
- Add "scopedRegistries" and the package name to `Packages/manifest.json` in Unity Project
  - You have only to add `com.tsgcpp.unitygithubpackageexample.integration`

```json
{
  "scopedRegistries": [
    {
      "name": "tsgcpp public",
      "url": "https://npm.pkg.github.com/@tsgcpp",
      "scopes": [
        "com.tsgcpp"
      ]
    }
  ],
  "dependencies": {
    "com.tsgcpp.unitygithubpackageexample.integration": "1.2.3",
    ...
  }
}
```
# Blogs
- [【GitHub Packages for Unity】限定配布も可能, GitHub Packages で Unity アセット配布](https://tsgcpp.hateblo.jp/entry/2021/08/01/001606)

