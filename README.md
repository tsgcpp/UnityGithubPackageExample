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
- Open `Packages/manifest.json`
- Add lines as below
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
