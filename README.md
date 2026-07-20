# Medical Analyzer UI

医療用分析装置を想定した、WPF / C# の学習用GUIアプリケーションです。

## 目的

React / TypeScriptで学習したUI設計の考え方を、WPF / C#へ展開することを目的としています。

医療現場で利用される装置を想定し、以下の観点を重視しています。

- 視認性の高い状態表示
- 誤操作を防ぐボタン制御
- システム状態の明確なフィードバック
- 操作しやすい画面レイアウト

## 現在の機能

- 装置状態の表示
- 検体操作パネル
- C#による検体データモデル
- 検体状態の列挙型管理
- `ObservableCollection`による検体データ管理
- `DataContext`とBindingによるデータ表示
- `DataGrid`による検体一覧表示
- 検体ID、検査項目、状態、登録時刻、進捗の表示
- 列単位の昇順・降順ソート
- 一覧の編集および新規行追加の制限
- ウィンドウサイズに追従するレイアウト

## 技術構成

- C#
- .NET 8
- WPF
- XAML
- Visual Studio 2022

## 実行方法

1. `MedicalAnalyzerLearning.sln` をVisual Studio 2022で開きます。
2. `MedicalAnalyzer.App` をスタートアッププロジェクトに設定します。
3. `F5`キーで実行します。

## 学習状況

Day 2まで完了しています。

### 学習済み

- WPFの基本レイアウト
- XAMLコントロール
- C#のクラスとプロパティ
- 列挙型
- オブジェクト初期化子
- `ObservableCollection`
- `DataContext`
- データバインディング
- `DataGrid`

### 今後の予定

- `INotifyPropertyChanged`
- MVVM
- Command
- 検体登録
- 入力検証
- 測定状態の変更
- 非同期処理
- 単体テスト

## 注意事項

本プロジェクトは学習およびポートフォリオ用のデモです。

実在する患者情報、医療判断、診断処理は含まれていません。
