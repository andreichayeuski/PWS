https://localhost:44357/WcfDataService1.svc/Notes?$orderby=Subj&$filter=(Note1%20gt%205)
Пример запроса из браузера к wcf data service.
Запрос GET, content-type - application/atom-xml, лучше показывать из POSTman, приятнее выглядит

wcf data service шаблон перестал поддерживаться после visual studio 2015, поэтому надо доустанавливать 
два расширения для вижлы: "WCF Data Services Template for VS 2017 and above" и "Unchase OData Connected Services"

подключать сервис надо через "добавить подключённую службу" (будет красивое окошечко, где надо выбрать Unchase OData)
