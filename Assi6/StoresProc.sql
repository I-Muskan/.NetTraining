create db BOOKDB;


create proc BOOK_SP
@BookId int,
@BookName varchar(255),
@Author varchar(50),
@Publisher varchar(100),
@Price DECIMAL(6,2)
as
begin
INSERT INTO Book(BookId,BookName,Author,Publisher,Price)Values(@BookId,@BookName,@Author,@Publisher,@Price)
end

exec BOOK_SP 1001,'Rich Dad Poor Dad','giri singh','mahindra',400;

create proc BOOKAllRecords_SP
as
begin
SELECT * FROM Book
end
exec BOOKAllRecords_SP;
create proc UpdatedBook
@BookId int,
@BookName varchar(255),
@Author varchar(50),
@Publisher varchar(100),
@Price DECIMAL(6,2)
as
begin
Update Book SET BookName=@BookName,Author=@Author,Publisher=@Publisher,Price=@Price WHERE BookId=@BookId;
end
create proc DeleteBook
@BookId int
as
begin
DELETE FROM Book WHERE BookId=@BookId;
end
exec BOOKAllRecords_SP;