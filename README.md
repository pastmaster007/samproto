## This is sample reverse string tutorial to explain grpc between go server and go client/netcore2 client..

It has following source code folders
- go server
- go client
- netcore2 csharp client

Below instructions are only for macOS X. i assume below steps might also works for linux.

### Prerequisites:
1. Homebrew command line package manager utility
2. Go lang compiler
3. Python@2, which comes default with macOS X
4. .Net core SDK, this project uses netcoreapp2.1
5. protoc compiler
6. grpc command line tool
7. grpc_csharp_plugin command line plugin tool


### Initial Approach:
#### Net core installation
goto https://www.microsoft.com/net/download
download Build apps SDK x64 installer
run installer

#### Go installation

gRPC requires Go 1.6 or higher.

```sh
$ go version
```

If go is not installed, you can install via Homebrew package manager and setup path variables.
Ref: https://stackoverflow.com/a/40129734
```sh
brew install go
export GOPATH=$HOME/.golang
export PATH=$PATH:$GOPATH/bin
```

#### Install gRPC

Use the following command to install gRPC.

```sh
$ go get -u google.golang.org/grpc
```

#### Install Protocol Buffers v3
Ref: http://google.github.io/proto-lens/installing-protoc.html
```sh
brew install protobuf
```

Next, install the protoc plugin for Go

``` sh
$ go get -u github.com/golang/protobuf/protoc-gen-go
```

#### Clone repository
``` sh
git clone https://github.com/pastmaster/samproto
cd samproto

#compile proto file into pb.go file
protoc -I ./sample ./sample/sample.proto --go_out=plugins=grpc:./sample

# run go server
go run ./goserver/main.go
```

open another tab in terminal
```sh
# run go client
go run ./goclient/main.go
```

open anothet tab in terminal for net core client
```sh
cd netcoreclient
dotnet run
```


#### steps to initiate new net core app from command line
```sh
# creates new dotnet console app
dotnet new console

# add required packages to compile and run
dotnet add package Google.Protobuf

dotnet add package Grpc

# add required packages to compile, after package download we can remove this package reference from .csproj file.
dotnet add package grpc.tools

# generates grpc files using proto file.
# make sure "protoc-gen-grpc" plugin requires full file path
~/.nuget/packages/grpc.tools/1.15.0/tools/macosx_x64/protoc \
-I../sample --csharp_out . --grpc_out . ../sample/sample.proto \
--plugin=protoc-gen-grpc=/Users/swx/.nuget/packages/grpc.tools/1.15.0/tools/macosx_x64/grpc_csharp_plugin 
```
