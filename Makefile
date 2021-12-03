install:
	ln -s /DevOps/brewery.service /etc/systemd/system/
	systemctl daemon-reload
	systemctl enable brewery && systemctl start brewery