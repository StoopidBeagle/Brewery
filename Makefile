install:
	cp DevOps/brewery.service /etc/systemd/system
	systemctl start brewery