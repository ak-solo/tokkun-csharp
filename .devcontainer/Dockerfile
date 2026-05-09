FROM mcr.microsoft.com/dotnet/sdk:10.0

# dotnet global tools を PATH に追加
ENV PATH="${PATH}:/root/.dotnet/tools"

# repl <章番号> で csharprepl を起動するシェル関数を追加
RUN echo 'repl() { n=$(printf "%02d" $1); csharprepl "/workspaces/tokkun-csharp/playground/Chapter${n}/repl.csx"; }' >> /root/.bashrc
