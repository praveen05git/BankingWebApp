create table customer(ssn_id int,
					customer_id int not null primary key Identity(100,1),
						customer_name varchar(100),
						age int,
						address varchar(100),
						state varchar(100),
						city varchar(100),
						status varchar(100),
						message varchar(100),
						lastupdated datetime)


create proc sp_addcustomer
@ssn_id int,
@customer_name varchar(100) ,
@age int ,
@address varchar(100) ,
@state varchar(100) ,
@city varchar(100),
@status varchar(100),
@message varchar(100),
@lastupdated datetime
as
begin
insert into customer(ssn_id,customer_name,age,address,state,city,status,message,lastupdated) values(@ssn_id,@customer_name,@age,@address,@state,@city,@status,@message,@lastupdated)
end

create proc sp_viewallcust
as
begin
select *from customer
end

create proc sp_updatecustomer
@customer_id int ,
@new_customer_name varchar(100),
@new_address varchar(100),
@new_age int,
@new_msg varchar(500) 
as
begin
update customer 
set customer_name=@new_customer_name,address=@new_address,age=@new_age,message=@new_msg
where customer_id=@customer_id
end

create proc sp_deletecustomer
@customer_id int
as begin
update customer set customer_name=null,ssn_id=-1,status='Inactive',message='Customer Deleted',state=null,address=null,city=null,age=null,lastupdated=GETDATE() where customer_id=@customer_id
end

------------------------------------------------------------------------------------------------------------------------------------------
create table accounts(account_id int Identity(20000,1) primary key,
					 customer_id int foreign key references customer(customer_id),
					   account_type varchar(100),
					   deposit_amount float,
					   status varchar(100),
					   created_date datetime,
					   message varchar(100))


create proc sp_addaccount
@customer_id int,
@account_type varchar(100),
@deposit_amount float
as begin
insert into accounts(customer_id,account_type,deposit_amount,status,created_date,message) values(@customer_id,@account_type,@deposit_amount,'Active',GetDate(),'Account Created')
end

create proc sp_displayaccid
as begin
select account_id from accounts 
end

create proc sp_displayaccid1
@custid int 
as begin
select account_id from accounts where customer_id=@custid
end

create proc sp_displayacctype
@account_id int
as begin
select account_type,deposit_amount from accounts where account_id=@account_id
end

create proc sp_deleteaccount
@account_id int
as begin
update accounts set account_type=null,deposit_amount=-1,status='Inactive',created_date=GetDate(),message='Account Deleted' where account_id=@account_id;
end

-----------------------------------------------------------------------------------------------------------------

create proc sp_csearch
@ssn_id int,
@customer_id int
as begin
select * from customer where ssn_id=@ssn_id or customer_id=@customer_id
end

create proc sp_csearch1
@customer_id int
as begin
select * from customer where customer_id=@customer_id
end

create proc sp_asearch
@customer_id int,
@account_id int
as begin
select * from accounts where customer_id=@customer_id or account_id=@account_id
end

----------------------------------------------------------------------------------------------------------

create table transact(  account_id int,
						transaction_id bigint identity(10000,1),
						transaction_date datetime ,
						amount float ,
						balance float,
						description varchar(100))


create proc sp_deposit
@account_id int,
@deposit_amount float,
@balance float
as begin
insert into transact(account_id,transaction_date,amount,balance,description)values(@account_id,GetDate(),@deposit_amount,@balance,'Deposited')
update accounts set deposit_amount=@balance where account_id=@account_id;
end

create proc sp_wd
@account_id int,
@deposit_amount float,
@balance float
as begin
insert into transact(account_id,transaction_date,amount,balance,description)values(@account_id,GetDate(),@deposit_amount,@balance,'Withdrawn')
update accounts set deposit_amount=@balance where account_id=@account_id;
end

create proc sp_transfer
@account_id int ,
@transfer_amount float,
@sourcebalance float,
@target_id int,
@targetbalance float
as begin
insert into transact values(@account_id,GetDate(),@transfer_amount,@sourcebalance,'Transferred')
insert into transact values(@target_id,GetDate(),@transfer_amount,@targetbalance,'Received')
update accounts set deposit_amount=@sourcebalance where account_id=@account_id
update accounts set deposit_amount=@targetbalance where account_id=@target_id 
end

select *from accounts
create proc sp_amtview
@id int
as
begin
select deposit_amount as sbal from accounts where account_id=@id
end
--------------------------------------------------------------------------------------------------------------
create proc sp_viewtransaction
@accountid int,
@startdate datetime,
@enddate datetime
as begin
select transaction_id,transaction_date,amount,balance,description from transact
where account_id=@accountid and transaction_date>=@startdate and transaction_date<=@enddate
end

create proc sp_viewtransaction1
@accountid int,
@count int 
as begin
select top (@count) transaction_id,transaction_date,amount,balance,description from transact
where account_id=@accountid 
order by transaction_date Desc
end

select *from transact 
----------------------------------------------------------------------------------------------------------

create proc sp_viewcstatus
as
begin
select ssn_id,customer_id,message,status,lastupdated from customer
end

create proc sp_viewastatus
as
begin
select customer_id,account_id,account_type,status,message,created_date from accounts
end

create proc sp_depsearch
@account_id int
as begin
select * from accounts where account_id=@account_id
end