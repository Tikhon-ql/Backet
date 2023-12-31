# Backet
---

### 1 Описание проекта:
Backet позволяет пользователям сохранять их игровую статистику, а также просматривать их динамику. API предоставляет возможность для:
- Аутентификация и авторизация пользователей.
- Добавления результата игры.
- Отображение диаграмм по всем типам результатов.
### Backend
---
#### Документация API
Документация API доступна по следующему адресу: https://localhost:44309/swagger. Вы найдете здесь описание доступных эндпоинтов и сможете протестировать их прямо из браузера. 


#### Графический материал:
- [Диаграммы активностей](https://github.com/Tikhon-ql/Backet/blob/main/documentation/activities/activities.md)
- [Диаграмма развертывания](https://github.com/Tikhon-ql/Backet/blob/main/documentation/deploy/deploy.md)
- [Диаграммы последовательности](https://github.com/Tikhon-ql/Backet/blob/main/documentation/sequence/sequence.md)
- [Диаграмма состояний](https://github.com/Tikhon-ql/Backet/blob/main/documentation/state/state.md)
- [Диаграмма компонентов](https://github.com/Tikhon-ql/Backet/blob/main/documentation/components/components.md)
- [Диаграмма вариантов использования](https://github.com/Tikhon-ql/Backet/blob/main/documentation/use_case/use_cast.md)


#### Готовый проект:

- [Исходный код проекта](https://github.com/Tikhon-ql/Backet).

#### Аутентификация
Для доступа к некоторым эндпоинтам API требуется аутентификация. Вы можете использовать токен JWT для аутентификации. Получите токен, отправив POST-запрос на эндпоинт /authentication/login с вашими учетными данными.

#### Установка

Чтобы развернуть API локально, выполните следующие шаги:

1. Убедитесь, что у вас установлен .NET Core SDK. Если нет, скачайте его с [официального сайта](https://dotnet.microsoft.com/download/dotnet).

2. Клонируйте репозиторий:

	>git clone https://github.com/Tikhon-ql/Backet.git
	
3. Перейдите в директорию проекта:

	>cd code
	
4. В файле конфигурации appsettings.json настройте подключение к базе данных и другие параметры, если это необходимо.

5. Выполните миграцию базы данных:
  >update-database

6. Запустите API:

	>dotnet run
	
API будет доступен по адресу http://localhost:44309.
### Frontend
---

#### Графический материал:
- [Диаграммы](https://github.com/Tikhon-ql/Backet)		
- [Скриншоты](https://github.com/Tikhon-ql/Backet) 

#### Готовый проект:

- [Исходный код проекта](https://github.com/Tikhon-ql/Backet).

#### Установка

Чтобы развернуть API локально, выполните следующие шаги:

1. Подключите необходимые модули для запуска приложения:
 >npm i

2. Запустите приложение:
  >npm start
	
#### Взиамодействие
Мы приветствуем вклад в развитие этого проекта. Если у вас есть идеи, предложения или исправления, пожалуйста, создайте Pull Request.

#### Лицензия
Этот проект лицензирован в соответствии с MIT License.
