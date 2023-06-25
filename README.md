# PacketMonitor

Este é um sniffer de rede desenvolvido em C# com Windows Forms usando o Visual Studio 2022. O sniffer permite escolher o adaptador de rede e filtrar entre pacotes TCP, UDP ou ambos.

## Funcionalidades

- Captura de pacotes: O sniffer é capaz de capturar pacotes de rede em tempo real, permitindo a análise do tráfego em um determinado ambiente.

- Filtragem de pacotes: É possível configurar o sniffer para filtrar pacotes com base em diferentes critérios, incluindo endereço IP de origem/destino, protocolo de transporte (TCP, UDP), portas, entre outros. Isso permite uma análise mais direcionada do tráfego de rede.

- Visualização de informações: O sniffer exibe informações detalhadas sobre cada pacote capturado, como endereços IP de origem e destino, portas de origem e destino, tamanho do pacote, dados payload e outros detalhes relevantes.

- Interface amigável: A aplicação possui uma interface intuitiva e fácil de usar, fornecendo uma experiência agradável ao usuário durante a captura e análise dos pacotes.

## Requisitos

Antes de executar a aplicação, certifique-se de atender aos seguintes requisitos:

- Visual Studio 2022 instalado.
- Visual C++ Redistributable (x86) instalado.
- .NET Framework 4.7.2 instalado.

## Dependências

O sniffer utiliza as seguintes bibliotecas externas:

- PacketDotNet: Biblioteca para manipulação de pacotes de rede em C#.
- SharpCap: Biblioteca para captura de pacotes de rede em C#.

Certifique-se de instalar essas dependências antes de executar o projeto.

## Instruções de Uso

1. Clone ou faça o download do repositório.
2. Abra o projeto no Visual Studio 2022.
3. Compile o projeto para gerar o executável.
4. Certifique-se de ter as dependências instaladas corretamente.
5. Execute o aplicativo gerado.
