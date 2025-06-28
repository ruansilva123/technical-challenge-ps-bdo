# Util links 

### Architecture

https://dev.to/godoi/como-estruturar-sua-aplicacao-angular-26pg


### Develop

https://github.com/nvm-sh/nvm?tab=readme-ov-file#installing-and-updating
https://v17.angular.io/tutorial/first-app
https://consolelog.com.br/introducao-ao-angular-17/
https://www.npmjs.com/package/ngx-toastr
https://tailwindcss-com.translate.goog/docs/installation/framework-guides/angular?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt&_x_tr_pto=tc&_x_tr_hist=true
https://medium.com/@rohanayush05/tailwind-meets-angular-17-60de96371157
https://v17.material.angular.dev/components/button/overview
https://docs.docker.com/engine/install/ubuntu/
https://learn.microsoft.com/pt-br/ssms/install/install

### Assets

https://undraw.co/search/page-not-found

### Comands:

Run project:
install nvm on Linux: curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.40.3/install.sh | bash
install node 20: nvm install 20
use node: nvm use 20
npm install -g @angular/cli@17.0
verify install: ng version

Start New Project (Frontend):
ng new --skip-git --strict corporate-resources-ui
cd corporate-resources-ui
npm install ngx-toastr --save
npm install @angular/animations --save

### Start Database (SQL Server in WSL2 with Docker)

DB name: CorporateResource

https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver17&tabs=cli&pivots=cs1-bash
After run instalation, open SQL Management Studio and loggin:
- docker ps
- Server Name: 127.0.0.1,1433
- Authentication: SQL Server Authentication
- User Name: sa
- Password: <your-password>
- Encrypt: Optional