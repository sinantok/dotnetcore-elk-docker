# dotNetCore-ELK-Docker

Bu uygulama, **Docker** üzerinde çalışan **ElasticSearch** ve **Kibana**'nın **.Net Core** ile beraber kullanım örneğidir. dotNET Core üzerinde geliştirilen uygulamada **NLog** kütüphanesi kullanılarak log yakalanıp ElasticSearch üzerinde index'lenerek tutulmaktadır. Ardında bu log'lar tutulan index'lere göre Kibana üzerinde izlenebilmektedir **(monitoring)**. 

## Gereksinimler

Bilgisayarınızın işletim sistemine göre Docker kurulmadır. Ardından projenin dizininde komut satırı açılarak `docker-compose up -d` komutu girilir ve docker-compose.yml dosyası içerisinde tanımlanan ElasticSearch ve Kibana kurulup çalıştırılmaya başlanır. Son olarak `dotnet restore` komutu ile, ihtiyaç varsa projeye araçlar ve bağımlılıklar yüklenir. 

## Kullanım

Komut satırıdan `dotnet build` ve ardından `dotnet run` komutları ile proje çalıştırılır. Kullanıma devam etmek için gerekli istek örnekleri aşağıda açıklamalarıyla listelenmiştir:

- _http://localhost:9200/_ Docker üzerinde çalışan ElasticSearch'e ulaşılır
- _http://localhost:5601/_ Docker üzerinde çalışan Kibana'ya ulaşılır
- _http://localhost:3000/api/log/error/_ static olarak belirlenen error log kaydı yapılır
- _http://localhost:3000/api/log/info/_ static olarak belirlenen information log kaydı yapılır  
- _http://localhost:3000/api/log/res_ static olarak belirlenen error log kaydı yapılır

Daha sonra ElasticSearch üzerinde http://localhost:9200/_cat/indices?v isteği ile indices listelemesi yapılır. Buradaki index'lere göre Kibana içerisinden log'larımıza ait index ayarlarının yapılması ile log'lar izlenebillir hale gelir.

